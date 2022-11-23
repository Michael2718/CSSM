using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    internal class Statistics : INotifyPropertyChanged {
        public Statistics(SystemClock clock) {
            commonTime = clock;
            Subscribe();
        }
        public void Clear() {
            TerminatedProcessesCount = 0;
            ArrivalProcessesCount = 0;
            CpuFreeTime = 0;
            CpuUtilization = 0;
            Throughput = 0;
        }
        private void Subscribe() {
            commonTime.PropertyChanged += PropertyChangedHandler;
        }
        private void Unsubscribe() {
            commonTime.PropertyChanged -= PropertyChangedHandler;
        }
        public long TerminatedProcessesCount {
            get => terminatedProcessesCount;
            set {
                terminatedProcessesCount = value;
                OnPropertyChanged();
            }
        }
        public long ArrivalProcessesCount {
            get => arrivalProcessesCount;
            set {
                arrivalProcessesCount = value;
                OnPropertyChanged();
            }
        }
        public long CpuFreeTime {
            get => cpuFreeTime;
            set {
                cpuFreeTime = value;
                OnPropertyChanged();
            }
        }
        public double CpuUtilization {
            get => cpuUtilization;
            private set {
                cpuUtilization = value;
                OnPropertyChanged();
            }
        }
        public double Throughput {
            get => throughput;
            private set {
                throughput = value;
                OnPropertyChanged();
            }
        }
        private SystemClock commonTime;
        private long terminatedProcessesCount;
        private long arrivalProcessesCount;
        private long cpuFreeTime;
        private double cpuUtilization;
        private double throughput;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Clock") {
                CpuUtilization = ArrivalProcessesCount == 0 ? 0 : (commonTime.Clock - CpuFreeTime) / (double)commonTime.Clock;
                Throughput = (double)TerminatedProcessesCount / commonTime.Clock;
            }
        }
    }
}