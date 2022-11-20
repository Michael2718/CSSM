using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    public class Memory : INotifyPropertyChanged {
        private long occupiedSize;
        public long Size { get; private set; }
        public long FreeSize {
            get => Size - occupiedSize;
            private set { }
        }
        public long OccupiedSize {
            get => occupiedSize;
            set {
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
                OnPropertyChanged();
            }
        }
        public void Save(long size) {
            Size = size;
            OccupiedSize = 0;
        }
        public void Clear() {
            FreeSize = 0;
            OccupiedSize = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
