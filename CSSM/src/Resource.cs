using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    class Resource : INotifyPropertyChanged {
        private Process activeProcess;
        public Process ActiveProcess {
            get => activeProcess;
            set {
                activeProcess = value;
                OnPropertyChanged();
            }
        }
        public void WorkingCycle() {
            if (!IsFree()) {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree() {
            return activeProcess == null;
        }

        public void Clear() {
            activeProcess = null;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
