namespace CSSM {
    public enum ProcessStatus {
        ready,
        running,
        waiting,
        terminated
    }
    public class Process : IComparable<Process> {
        public Process(long pId, long addrSpace) {
            id = pId;
            AddrSpace = addrSpace;
            name = "P" + pId.ToString();
            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime() {
            if (workTime < BurstTime) {
                workTime++;
                return;
            } else if (workTime == BurstTime) {
                if (Status == ProcessStatus.running) {
                    Status = random.Next(0, 4) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                    if (Status == ProcessStatus.waiting) {
                        newEventArgs.DeviceNumber = (int)random.Next(1, 4);
                        OnFreeingAResource(newEventArgs);
                        return;
                    }
                } else {
                    Status = ProcessStatus.ready;
                }
                OnFreeingAResource(newEventArgs);
            }
        }

        public void ResetWorkTime() {
            workTime = 0;
        }

        public override string ToString() {
            return "Proc: " + name + ' ' + id + " BurstTime: " + BurstTime + " WorkTime: "
                + workTime + " Status: " + Status;
        }
        public int CompareTo(Process? otherProc) {
            if (otherProc == null) {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }

        private void OnFreeingAResource(NewEventArgs? e = null) {
            FreeingAResource?.Invoke(this, e);
        }
        private long id;
        private string name;
        private long workTime;
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long ReadyQueueArrivalTime { get; set; }
        public long AddrSpace { get; private set; }
        public long ArrivalTime { get; set; }
        public long CommonWaitingTime { get; set; }

        private Random random = new Random();
        NewEventArgs newEventArgs = new NewEventArgs();
        public event EventHandler FreeingAResource;
    }
}
