﻿using System.ComponentModel;
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
                ActiveProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree() {
            return ActiveProcess == null;
        }

        public void Clear() {
            ActiveProcess = null;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
