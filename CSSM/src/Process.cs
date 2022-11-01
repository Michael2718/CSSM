namespace CSSM {
    enum ProcessStatus {
        ready,
        running,
        waiting,
        terminated
    }
    class Process : IComparable<Process> {

        public int CompareTo(Process? otherProc) {
            if(otherProc == null) {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }

        public Process(long pId, long addrSpace) {
            id = pId;
            AddrSpace = addrSpace;
            name = "p" + id;
            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime() {
            if(workTime < BurstTime) {
                workTime++;
                return;
            }

            OnFreeingAResource();
        }

        public void ResetWorkTime() {
            workTime = 0;
        }

        public override string ToString() {
            return "Proc: " + id + ' ' + "BurstTime: " + BurstTime + ' ' + "WorkTime: "
                + workTime + ' ' + "Status: " + Status;
        }

        public event EventHandler FreeingAResource;

        private void OnFreeingAResource() {
            if(FreeingAResource != null) {
                FreeingAResource(this, null);
            }
        }

        public long BurstTime { get; set; }

        public ProcessStatus Status { get; set; }

        public long AddrSpace { get; private set; }

        private long id;
        private string name;
        private long workTime;
        private Random resourceRand = new Random();
    }
}
