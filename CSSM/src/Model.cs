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

			readyQueue = new Queues.PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());

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
			Ram.Save(ModelSettings.RamSize);
			memoryManager.Save(Ram);
		}
		public void WorkingCycle() {
			Clock.WorkingCycle();
			if (processRand.NextDouble() <= ModelSettings.Intensity) {
				Process process = new(idGen.Id, processRand.Next(ModelSettings.MinAddrSpace, ModelSettings.MaxAddrSpace + 1));
				if (memoryManager.Allocate(process.AddrSpace) != null) {
                    process.ArrivalTime = Clock.Clock;
                    process.BurstTime = processRand.Next(ModelSettings.MinBurstTime, ModelSettings.MaxBurstTime + 1);
					readyQueue = readyQueue.Put(process);
                    process.ReadyQueueArrivalTime = Clock.Clock;
                    if (Cpu.IsFree()) {
						putProcessOnResource(Cpu);
                    }
				}
			}
            if (cpuScheduler.MoreCheck() && cpuScheduler.Check()) {
                Unsubscribe(Cpu);
                ReadyQueue = cpuScheduler.Switch();
                Subscribe(Cpu);
            }
            Cpu.WorkingCycle();
			Device1.WorkingCycle();
			Device2.WorkingCycle();
			Device3.WorkingCycle();
		}

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
				} else if (resource == Device3){
					DeviceQueue3 = deviceScheduler3.Session();
				}
			}
			if (resource is not null) {
				Subscribe(resource);
			}
		}
		private void FreeingResourceEventHandler(object sender, EventArgs e) {
			Process? process = sender as Process;
			NewEventArgs? device = e as NewEventArgs;

			if (process is not null && process.Status == ProcessStatus.terminated) {
				Unsubscribe(Cpu);
				Cpu.Clear();
				memoryManager.Free(process.AddrSpace);
				if (readyQueue.Count != 0) {
					putProcessOnResource(Cpu);
				}
			} else if (process is not null && process.Status == ProcessStatus.waiting && device is not null) {
				Unsubscribe(Cpu);
				Cpu.Clear();
				if (readyQueue.Count != 0) {
					putProcessOnResource(Cpu);
				}

				process.ResetWorkTime();
				process.BurstTime = processRand.Next(ModelSettings.MinBurstTime, ModelSettings.MaxBurstTime + 1);

				if (device.DeviceNumber == 1) {
					DeviceQueue1 = DeviceQueue1.Put(process);
					if (Device1.IsFree()) {
						putProcessOnResource(Device1);
					}
				} else if (device.DeviceNumber == 2) {
					DeviceQueue2 = DeviceQueue2.Put(process);
					if (Device2.IsFree()) {
						putProcessOnResource(Device2);
					}
				} else if (device.DeviceNumber == 3) {
					DeviceQueue3 = DeviceQueue3.Put(process);
					if (Device3.IsFree()) {
						putProcessOnResource(Device3);
					}
				}
			} else if (process is not null && process.Status == ProcessStatus.ready && device is not null) {
				if (device.DeviceNumber == 1) {
					Unsubscribe(Device1);
					Device1.Clear();
					if (deviceQueue1.Count != 0) {
						putProcessOnResource(Device1);
					}
				} else if (device.DeviceNumber == 2) {
					Unsubscribe(Device2);
					Device2.Clear();
					if (deviceQueue2.Count != 0) {
						putProcessOnResource(Device2);
					}
				} else if (device.DeviceNumber == 3) {
					Unsubscribe(Device3);
					Device3.Clear();
					if (deviceQueue3.Count != 0) {
						putProcessOnResource(Device3);
					}
				}
				process.ResetWorkTime();
				process.BurstTime = processRand.Next(ModelSettings.MinBurstTime, ModelSettings.MaxBurstTime + 1);
				ReadyQueue = readyQueue.Put(process);
				process.ReadyQueueArrivalTime = Clock.Clock;
				if (Cpu.IsFree()) {
					putProcessOnResource(Cpu);
				}
			} else {
				throw new Exception("Unknown process status");
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
	}
}
