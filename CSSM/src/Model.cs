using Queues;
using Structures;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
	class Model : INotifyPropertyChanged {
		public Model() {
			Clock = new SystemClock();

			Cpu = new Resource();

			Device1 = new Resource();
			Device2 = new Resource();
			Device3 = new Resource();

			Ram = new Memory();

			idGen = new IdGenerator();

			readyQueue = new Queues.PriorityQueue<Process, BinarySearchTree<Process>>(new BinarySearchTree<Process>());

			deviceQueue1 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
			deviceQueue2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
			deviceQueue3 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());

			cpuScheduler = new CPUScheduler(Cpu, readyQueue);

			memoryManager = new MemoryManager();

			deviceScheduler1 = new DeviceScheduler(Device1, deviceQueue1);
			deviceScheduler2 = new DeviceScheduler(Device2, deviceQueue2);
			deviceScheduler3 = new DeviceScheduler(Device3, deviceQueue3);

			processRand = new Random();

			ModelSettings = new Settings();
		}

		public void SaveSettings() {
			Ram.Save(ModelSettings.ValueOfRAMSize);
			memoryManager.Save(Ram);
		}
		public void WorkingCycle() {
			Clock.WorkingCycle();
			if (processRand.NextDouble() <= ModelSettings.Intensity) {
				Process proc = new(idGen.Id, processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
				if (memoryManager.Allocate(proc.AddrSpace) != null) {
					proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
					Subscribe(proc);
					readyQueue = readyQueue.Put(proc);
					if (cpu.IsFree()) {
						cpuScheduler.Session();
					}
				}
			}
			Cpu.WorkingCycle();
			Device1.WorkingCycle();
			Device2.WorkingCycle();
			Device3.WorkingCycle();
		} // TODO: WorkingCycle()

		public void Clear() {
			Unsubscribe(Cpu);
			Unsubscribe(Device1);
			Unsubscribe(Device2);
			Unsubscribe(Device3);

			Cpu.Clear();

			Device1.Clear();
			Device2.Clear();
			Device3.Clear();

			ReadyQueue = readyQueue.Clear();

			DeviceQueue1 = deviceQueue1.Clear();
			DeviceQueue2 = deviceQueue2.Clear();
			DeviceQueue3 = deviceQueue3.Clear();

			Clock.Clear();
			idGen.Clear();
		}
		private void Subscribe(Resource resource) {
			if (resource.ActiveProcess != null)
				resource.ActiveProcess.FreeingAResource += FreeingResourceEventHandler;
		}

		private void Unsubscribe(Resource resource) {
			if (resource.ActiveProcess != null) {
				resource.ActiveProcess.FreeingAResource -= FreeingResourceEventHandler;
			}
		}
		private void putProcessOnResource(Resource resource) {
			if (resource == Cpu && resource is not null && resource.ActiveProcess is not null) {
				ReadyQueue = cpuScheduler.Session();
				resource.ActiveProcess.CommonWaitingTime += (Clock.Clock - resource.ActiveProcess.ReadyQueueArrivalTime);
			} else {
				if (resource == Device1) {
					DeviceQueue1 = deviceScheduler1.Session();
				} else if (resource == Device2) {
					DeviceQueue2 = deviceScheduler2.Session();
				} else {
					DeviceQueue3 = deviceScheduler3.Session();
				}
			}
			if (resource is not null) {
				Subscribe(resource);
			}
		}
		private void FreeingResourceEventHandler(object? sender, EventArgs e) {
			Process? proc = sender as Process;
			if (proc.Status == ProcessStatus.waiting) //Процесс покидает внешнее устройство
			{
				device.Clear();
				proc.Status = ProcessStatus.ready;
				proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
						 modelSettings.MaxValueOfBurstTime + 1);
				proc.ResetWorkTime();

				readyQueue = readyQueue.Put(proc);

				if (cpu.IsFree()) {
					readyQueue = cpuScheduler.Session();
				}

				if (deviceQueue.Count != 0) {
					deviceQueue = deviceScheduler.Session();
				}
			} else //Процесс покидает процессор
			  {
				cpu.Clear();
				if (readyQueue.Count != 0) {
					readyQueue = cpuScheduler.Session();
				}

				proc.Status = processRand.Next(0, 2) == 0 ? ProcessStatus.terminated :
						ProcessStatus.waiting;
				if (proc.Status == ProcessStatus.terminated) {
					memoryManager.Free(proc.AddrSpace);
					Unsubscribe(proc);
				} else {
					proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
						modelSettings.MaxValueOfBurstTime + 1);
					proc.ResetWorkTime();
					deviceQueue = deviceQueue.Put(proc);
					if (device.IsFree()) {
						deviceQueue = deviceScheduler.Session();
					}
				}
			}
		} // TODO: FreeingResourceEventHandler()

		public readonly SystemClock Clock;

		public readonly Resource Cpu;

		public readonly Resource Device1;
		public readonly Resource Device2;
		public readonly Resource Device3;

		public readonly Memory Ram;

		private IdGenerator idGen;

		private IQueueable<Process> readyQueue;

		private IQueueable<Process> deviceQueue1;
		private IQueueable<Process> deviceQueue2;
		private IQueueable<Process> deviceQueue3;

		private CPUScheduler cpuScheduler;

		private MemoryManager memoryManager;

		private DeviceScheduler deviceScheduler1;
		private DeviceScheduler deviceScheduler2;
		private DeviceScheduler deviceScheduler3;

		private Random processRand;

		public readonly Settings ModelSettings;

		public IQueueable<Process> ReadyQueue {
			get => readyQueue;
			set {
				readyQueue = value;
				OnPropertyChanged();
			}
		}
		public IQueueable<Process> DeviceQueue1 {
			get => deviceQueue1;
			set {
				deviceQueue1 = value;
				OnPropertyChanged();
			}
		}
		public IQueueable<Process> DeviceQueue2 {
			get => deviceQueue2;
			set {
				deviceQueue2 = value;
				OnPropertyChanged();
			}
		}
		public IQueueable<Process> DeviceQueue3 {
			get => deviceQueue3;
			set {
				deviceQueue3 = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
