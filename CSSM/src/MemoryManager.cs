namespace CSSM {
    public class MemoryManager {
        private Memory memory;

        public MemoryManager() {
            this.memory = new Memory();
        }

        public void Save(Memory memory) {
            this.memory = memory;
        }

        public Memory? Allocate(long size) {
            if (size <= memory.FreeSize) {
                memory.OccupiedSize += size;
                return memory;
            }
            return null;
        }

        public Memory Free(long size) {
            memory.OccupiedSize -= size;
            return memory;
        }
    }
}
