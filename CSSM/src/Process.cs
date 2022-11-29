namespace CSSM {
    public enum ProcessStatus {
        ready,
        running,
        waiting,
        terminated
    }
    public class Process : IComparable<Process> {
        private readonly long id;
        private readonly string name;
        private long workTime;

        private readonly Random random = new();
        readonly ResourceEventArgs device = new();
        public event EventHandler? FreeingResource;

        public Process(long pId, long addrSpace) {
            id = pId;
            AddrSpace = addrSpace;
            name = "P" + pId.ToString();
            Status = ProcessStatus.ready;
        }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long ReadyQueueArrivalTime { get; set; }
        public long AddrSpace { get; private set; }
        public long ArrivalTime { get; set; }
        public long CommonWaitingTime { get; set; }

        public void IncreaseWorkTime() {
            workTime++;
            if (workTime == BurstTime) {
                if (Status == ProcessStatus.running) {
                    Status = random.Next(0, 4) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                    if (Status == ProcessStatus.waiting) {
                        device.DeviceNumber = (int)random.Next(1, 4);
                        OnFreeingAResource(device);
                        return;
                    }
                } else {
                    Status = ProcessStatus.ready;
                }
                OnFreeingAResource(device);
            }
        }
        public void ResetWorkTime() {
            workTime = 0;
        }
        public override string ToString() {
            return "Proc: " + name + " Status: " + Status + " BurstTime: " + BurstTime.ToString() +
                " WorkTime: " + workTime.ToString() + " AddrSpace: " + AddrSpace.ToString();
        }
        public int CompareTo(Process? otherProc) {
            if (otherProc == null) {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }
        private void OnFreeingAResource(ResourceEventArgs e) {
            FreeingResource?.Invoke(this, e);
        }
    }
}
