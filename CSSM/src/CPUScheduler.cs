using Queues;

namespace CSSM {
    class CPUScheduler {
        private readonly Resource resource;
        private readonly IQueueable<Process> queue;

        public CPUScheduler(Resource resource, IQueueable<Process> queue) {
            this.resource = resource;
            this.queue = queue;
        }
        public IQueueable<Process> Session() {
            Process newActiveProcess = queue.Item();
            newActiveProcess.Status = ProcessStatus.running;
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }
        public bool Check() {
            return resource.ActiveProcess != null && queue.Count != 0 && resource.ActiveProcess.BurstTime > queue.Item().BurstTime;
        }
        public IQueueable<Process> Switch() {
            if (resource.ActiveProcess is null) {
                throw new Exception("Resource or ActiveProcess is null");
            }
            Process newActiveProcess = resource.ActiveProcess;
            newActiveProcess.Status = ProcessStatus.ready;
            resource.ActiveProcess = queue.Item();
            resource.ActiveProcess.Status = ProcessStatus.running;
            queue.Remove();
            queue.Put(newActiveProcess);
            return queue;
        }
    }
}
