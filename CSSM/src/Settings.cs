namespace CSSM {
    class Settings {
        private double intensity;
        private int minBurstTime;
        private int maxBurstTime;
        private int ramSize;
        private int minAddrSpace;
        private int maxAddrSpace;
        public double Intensity {
            get => intensity;
            set => intensity = value;
        }
        public int MinBurstTime {
            get => minBurstTime;
            set => minBurstTime = value;
        }
        public int MaxBurstTime {
            get => maxBurstTime;
            set => maxBurstTime = value;
        }
        public int RamSize {
            get => ramSize;
            set => ramSize = value;
        }
        public int MinAddrSpace {
            get => minAddrSpace;
            set => minAddrSpace = value;
        }
        public int MaxAddrSpace {
            get => maxAddrSpace;
            set => maxAddrSpace = value;
        }
    }
}
