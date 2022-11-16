namespace CSSM {
    class Memory {
        public long Size {
            get;
            private set;
        }
        public long FreeSize {
            get;
            private set;
        }
        public void Save(long size) {
            Size = size;
            occupiedSize = 0;
            FreeSize = size;
        }
        public void Clear() {
            occupiedSize = 0;
            FreeSize = Size;
        }
        public long OccupiedSize {
            get { return occupiedSize; }
            set { occupiedSize = value; }
        }

        private long occupiedSize;
    }
}
