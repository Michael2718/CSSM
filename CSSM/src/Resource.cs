using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    class Resource : INotifyPropertyChanged {
        private Process? activeProcess;
        public Process? ActiveProcess {
            get { return activeProcess; }
            set {
                activeProcess = value;
                OnPropertyChanged();
            }
        }
        public void WorkingCycle() {
            if(!IsFree()) {
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
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
