using Queues;
using Structures;
using System.ComponentModel;

namespace CSSM {
	class Model {
		public Model() {
			Clock = new SystemClock();
			deviceQueue = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
			readyQueue = new Queues.PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());

			//q = new Structures.BinarySearchTree
			modelSettings = new Settings();
			idGen = new IdGenerator();
			processRand = new Random();
			cpu = new Resource();
			device = new Resource();
			cpuScheduler = new CPUScheduler(cpu, readyQueue);
			deviceScheduler = new DeviceScheduler(device, deviceQueue);
			memoryManager = new MemoryManager();
			ram = new Memory();
		}

		public void SaveSettings() {
			ram.Save(modelSettings.ValueOfRAMSize);
			memoryManager.Save(ram);
		}
		public void WorkingCycle() {
			clock.WorkingCycle();
			if (processRand.NextDouble() <= modelSettings.Intensity) {
				Process proc = new(idGen.Id,
					processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
				if (memoryManager.Allocate(proc.AddrSpace) != null) {

					proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
						modelSettings.MaxValueOfBurstTime + 1);
					Subscribe(proc);
					readyQueue = readyQueue.Put(proc);
					if (cpu.IsFree()) {
						cpuScheduler.Session();
					}
				}
			}
			cpu.WorkingCycle();
			device.WorkingCycle();
		}

		public void Clear() {
			cpu.Clear();
			device.Clear();
			ram.Clear();
			readyQueue.Clear();
			deviceQueue.Clear();
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
		}
		public event PropertyChangedEventHandler PropertyChanged;
		private void Subscribe(Process? proc) {
			if (proc != null) {
				proc.FreeingAResource += FreeingResourceEventHandler;
			}
		}

		private void Unsubscribe(Process? proc) {
			if (proc != null) {
				proc.FreeingAResource -= FreeingResourceEventHandler;
			}
		}


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
			set => readyQueue = value;
		}

		public IQueueable<Process> DeviceQueue {
			get => deviceQueue;
			set => deviceQueue = value;
		}
	}
}
