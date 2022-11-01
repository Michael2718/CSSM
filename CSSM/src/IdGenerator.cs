﻿namespace CSSM {
    class IdGenerator {
        public long Id {
            get {
                return id == long.MaxValue ? 0 : ++id;
            }
        }
        public IdGenerator Clear() {
            if(this != null) {
                id = 0;
            }
            return this;
        }

        private long id;
    }
}
