namespace CSSM {
    class SystemClock {
        public void WorkingCycle() {
            clock++;
        }

        public void Clear() {
            clock = 0;
        }

        public long Clock {
            get {
                return clock;
            }
            private set {
                clock = value;
            }
        }
        private long clock;
    }
}
