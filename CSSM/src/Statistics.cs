using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    internal class Statistics : INotifyPropertyChanged {
        public Statistics(SystemClock clock) {
            commonTime = clock;
            Subscribe();
        }
        public void Clear() {
            ArrivalProcessesCount = 0;
            CpuFreeTime = 0;
            CpuUtilization = 0;
        }
        public void IncCPUFreeTime() {
            CpuFreeTime++;
        }
        public void IncArrivalProcessCount() {
            ArrivalProcessesCount++;
        }
        public long ArrivalProcessesCount { get; private set; }
        public long CpuFreeTime { get; private set; }
        public double CpuUtilization {
            get {
                return cpuUtilization;
            }
            private set {
                cpuUtilization = value;
                OnPropertyChanged();
            }
        }
        public long TerminatedProcessesCount { get; private set; }
        public double Throughput {
            get {
                return throughput;
            }
            private set {
                throughput = value;
                OnPropertyChanged();
            }
        }
        public void IncTerminatedProcessCount() {
            TerminatedProcessesCount++;
        }
        private SystemClock commonTime;
        private double cpuUtilization;
        private double throughput;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Subscribe() {
            commonTime.PropertyChanged += PropertyChangedHandler;
        }
        private void Unsubscribe() {
            commonTime.PropertyChanged -= PropertyChangedHandler;
        }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Clock") {
                CpuUtilization = ArrivalProcessesCount == 0 ? 0 : (commonTime.Clock - CpuFreeTime) / (double)commonTime.Clock;
                Throughput = (double)TerminatedProcessesCount / commonTime.Clock;
            }
        }
    }
}