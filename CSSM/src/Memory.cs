using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    public class Memory : INotifyPropertyChanged {
        private long occupiedSize;

        public event PropertyChangedEventHandler? PropertyChanged;

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
            FreeSize = Size;
            OccupiedSize = 0;
        }
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
