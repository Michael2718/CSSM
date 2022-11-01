namespace CSSM {
    class Memory {
        public void Save(long size) {
            Size = size;
            occupiedSize = 0;
            FreeSize = size;
        }
        public void Clear() {
            occupiedSize = 0;
            FreeSize = Size;
        }
        public long Size {
            get;
            private set;
        }
        public long OccupiedSize {
            get { return occupiedSize; }
            set { occupiedSize = value; }
        }
        public long FreeSize {
            get;
            private set;
        }

        private long occupiedSize;
    }
}
