using Queues;

namespace CSSM {
    class DeviceScheduler {
        private readonly Resource resourсe;
        private readonly IQueueable<Process> queue;

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
