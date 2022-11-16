using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSSM {
    public class Memory : INotifyPropertyChanged {
        private long occupiedSize;
        public long Size {
            get;
            private set;
        }
        public long FreeSize {
            get { return Size - occupiedSize; }
            private set { }
        }
        public long OccupiedSize {
            get { return occupiedSize; }
            set {
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
                OnPropertyChanged();
            }
        }
        public void Save(long size) {
            Size = size;
            occupiedSize = 0;
        }
        public void Clear() {
            occupiedSize = 0;
            FreeSize = Size;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
