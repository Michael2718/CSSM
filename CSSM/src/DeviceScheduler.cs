using Queues;

namespace CSSM {
    class DeviceScheduler {
        private Resource resourсe;
        private IQueueable<Process> queue;

        public DeviceScheduler(Resource resource, IQueueable<Process> queue) {
            this.resourсe = resource;
            this.queue = queue;
        }

        public IQueueable<Process> Session() {
            Process newActiveProcess = queue.Item();
            queue.Remove();
            resourсe.ActiveProcess = newActiveProcess;
            return queue;
        }
    }
}
