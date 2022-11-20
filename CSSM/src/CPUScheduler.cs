using Queues;

namespace CSSM {
    class CPUScheduler {
        private Resource resource;
        private IQueueable<Process> queue;

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
        public bool MoreCheck() {
            return resource.ActiveProcess != null && queue.Count != 0 && resource.ActiveProcess.LeftTime > queue.Item().LeftTime;
        }
        public IQueueable<Process> Switch() {
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
