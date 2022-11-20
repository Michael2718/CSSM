namespace CSSM {
    public class IdGenerator {
        private long id;
        public long Id => id == long.MaxValue ? 0 : ++id;

        public IdGenerator Clear() {
            if (this != null) {
                id = 0;
            }
            return this;
        }
    }
}
