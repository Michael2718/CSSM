using Queues;
using Structures;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    class Model : INotifyPropertyChanged {
        public readonly SystemClock Clock;
        public readonly Resource Cpu;

        public readonly Resource Device1;
        public readonly Resource Device2;
        public readonly Resource Device3;

        public readonly Memory Ram;

        public readonly IdGenerator IdGen;

        private IQueueable<Process> readyQueue;
        private IQueueable<Process> deviceQueue1;
        private IQueueable<Process> deviceQueue2;
        private IQueueable<Process> deviceQueue3;

        public readonly CPUScheduler CpuScheduler;

        public readonly MemoryManager MemoryManager;

        public readonly DeviceScheduler DeviceScheduler1;
        public readonly DeviceScheduler DeviceScheduler2;
        public readonly DeviceScheduler DeviceScheduler3;

        public readonly Random ProcessRand;

        public readonly Settings ModelSettings;
        public readonly Statistics Statistics;

        public event PropertyChangedEventHandler? PropertyChanged;

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

        public Model() {
            Clock = new SystemClock();

            Cpu = new Resource();

            Device1 = new Resource();
            Device2 = new Resource();
            Device3 = new Resource();

            Ram = new Memory();

            IdGen = new IdGenerator();

            readyQueue = new Queues.PriorityQueue<Process, BinarySearchTree<Process>>(new BinarySearchTree<Process>());

            deviceQueue1 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue3 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());

            CpuScheduler = new CPUScheduler(Cpu, ReadyQueue);

            MemoryManager = new MemoryManager();

            DeviceScheduler1 = new DeviceScheduler(Device1, DeviceQueue1);
            DeviceScheduler2 = new DeviceScheduler(Device2, DeviceQueue2);
            DeviceScheduler3 = new DeviceScheduler(Device3, DeviceQueue3);

            ProcessRand = new Random();

            ModelSettings = new Settings();

            Statistics = new Statistics(Clock);
        }

        public void SaveSettings() {
            Ram.Save(ModelSettings.RamSize);
            MemoryManager.Save(Ram);
        }
        public void WorkingCycle() {
            Clock.WorkingCycle();
            if (ProcessRand.NextDouble() <= ModelSettings.Intensity) {
                Process process = new(IdGen.Id, ProcessRand.Next(ModelSettings.MinAddrSpace, ModelSettings.MaxAddrSpace + 1));
                Statistics.ArrivalProcessesCount++;
                if (MemoryManager.Allocate(process.AddrSpace) != null) {
                    process.ArrivalTime = Clock.Clock;
                    process.BurstTime = ProcessRand.Next(ModelSettings.MinBurstTime, ModelSettings.MaxBurstTime + 1);
                    ReadyQueue = readyQueue.Put(process);
                    process.ReadyQueueArrivalTime = Clock.Clock;
                    if (Cpu.IsFree()) {
                        PutProcessOnResource(Cpu);
                        Statistics.CpuFreeTime++;
                    }
                }
            }
            if (CpuScheduler.Check()) {
                Unsubscribe(Cpu);
                ReadyQueue = CpuScheduler.Switch();
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
            Ram.Clear();

            ReadyQueue = readyQueue.Clear();

            DeviceQueue1 = deviceQueue1.Clear();
            DeviceQueue2 = deviceQueue2.Clear();
            DeviceQueue3 = deviceQueue3.Clear();

            Clock.Clear();
            IdGen.Clear();

            Statistics.Clear();
        }
        private void Subscribe(Resource resource) {
            if (resource.ActiveProcess is not null)
                resource.ActiveProcess.FreeingResource += FreeingResourceEventHandler;
        }

        private void Unsubscribe(Resource resource) {
            if (resource.ActiveProcess is not null) {
                resource.ActiveProcess.FreeingResource -= FreeingResourceEventHandler;
            }
        }
        private void PutProcessOnResource(Resource resource) {
            if (resource == Cpu) {
                ReadyQueue = CpuScheduler.Session();
                resource.ActiveProcess.CommonWaitingTime += (Clock.Clock - resource.ActiveProcess.ReadyQueueArrivalTime);
            } else {
                if (resource == Device1) {
                    DeviceQueue1 = DeviceScheduler1.Session();
                } else if (resource == Device2) {
                    DeviceQueue2 = DeviceScheduler2.Session();
                } else if (resource == Device3) {
                    DeviceQueue3 = DeviceScheduler3.Session();
                }
            }
            Subscribe(resource);
        }
        private void FreeingResourceEventHandler(object? sender, EventArgs e) {
            if (sender is not Process process || e is not ResourceEventArgs device) {
                throw new Exception("Resource or ActiveProcess is null");
            }

            if (process.Status == ProcessStatus.terminated) {
                Unsubscribe(Cpu);
                Cpu.Clear();
                MemoryManager.Free(process.AddrSpace);
                if (readyQueue.Count != 0) {
                    PutProcessOnResource(Cpu);
                }
                Statistics.TerminatedProcessesCount++;
            } else if (process.Status == ProcessStatus.waiting) {
                Unsubscribe(Cpu);
                Cpu.Clear();
                if (readyQueue.Count != 0) {
                    PutProcessOnResource(Cpu);
                }

                process.ResetWorkTime();
                process.BurstTime = ProcessRand.Next(ModelSettings.MinBurstTime, ModelSettings.MaxBurstTime + 1);

                if (device.DeviceNumber == 1) {
                    DeviceQueue1 = DeviceQueue1.Put(process);
                    if (Device1.IsFree()) {
                        PutProcessOnResource(Device1);
                    }
                } else if (device.DeviceNumber == 2) {
                    DeviceQueue2 = DeviceQueue2.Put(process);
                    if (Device2.IsFree()) {
                        PutProcessOnResource(Device2);
                    }
                } else if (device.DeviceNumber == 3) {
                    DeviceQueue3 = DeviceQueue3.Put(process);
                    if (Device3.IsFree()) {
                        PutProcessOnResource(Device3);
                    }
                }
            } else if (process.Status == ProcessStatus.ready) {
                if (device.DeviceNumber == 1) {
                    Unsubscribe(Device1);
                    Device1.Clear();
                    if (deviceQueue1.Count != 0) {
                        PutProcessOnResource(Device1);
                    }
                } else if (device.DeviceNumber == 2) {
                    Unsubscribe(Device2);
                    Device2.Clear();
                    if (deviceQueue2.Count != 0) {
                        PutProcessOnResource(Device2);
                    }
                } else if (device.DeviceNumber == 3) {
                    Unsubscribe(Device3);
                    Device3.Clear();
                    if (deviceQueue3.Count != 0) {
                        PutProcessOnResource(Device3);
                    }
                }
                process.ResetWorkTime();
                process.BurstTime = ProcessRand.Next(ModelSettings.MinBurstTime, ModelSettings.MaxBurstTime + 1);
                ReadyQueue = readyQueue.Put(process);
                process.ReadyQueueArrivalTime = Clock.Clock;
                if (Cpu.IsFree()) {
                    PutProcessOnResource(Cpu);
                }
            } else {
                throw new Exception("Unknown process status");
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
