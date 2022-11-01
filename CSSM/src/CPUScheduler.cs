using Queues;

namespace CSSM {
    class CPUScheduler {
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

        private Resource resource;
        private IQueueable<Process> queue;
    }
}
