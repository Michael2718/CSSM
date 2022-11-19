namespace CSSM {
    class Settings {
        private double intensity;
        private int minValueOfBurstTime;
        private int maxValueOfBurstTime;
        private int minValueOfAddrSpace;
        private int maxValueOfAddrSpace;
        private int valueOfRAMSize;
        public double Intensity {
            get => intensity;
            set => intensity = value;
        }
        public int MinValueOfBurstTime {
            get => minValueOfBurstTime;
            set => minValueOfBurstTime = value;
        }
        public int MaxValueOfBurstTime {
            get => maxValueOfBurstTime;
            set => maxValueOfBurstTime = value;
        }
        public int MinValueOfAddrSpace {
            get => minValueOfAddrSpace;
            set => minValueOfAddrSpace = value;

        }
        public int MaxValueOfAddrSpace {
            get => maxValueOfAddrSpace;
            set => maxValueOfAddrSpace = value;

        }
        public int ValueOfRAMSize {
            get => valueOfRAMSize;
            set => valueOfRAMSize = value;
        }
    }
}
