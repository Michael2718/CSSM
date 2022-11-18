namespace CSSM {
    public partial class FrmDetailed : Form {
        public FrmDetailed() {
            InitializeComponent();
        }

        public Label LabelTime {
            get { return labelTime; }
        }
        public TextBox TbCPU {
            get { return tbCPU; }
        }
        public TextBox TbDevice {
            get { return tbDevice1; }
        }
        public Label LabelFreeRAM {
            get { return lblFreeRam; }
        }
        public Label LabelOccupiedRAM {
            get { return lblOccupiedRam; }
        }


        public NumericUpDown ProcIntensity {
            get { return nudProcIntensity; }
        }
        public NumericUpDown MinBurstTime {
            get { return nudMinBurstTime; }
        }
        public NumericUpDown MaxBurstTime {
            get { return nudMaxBurstTime; }
        }
        public NumericUpDown RamSize {
            get { return cbRamSize; }
        }
        public NumericUpDown MinCpuSize {
            get { return nudMinAddrSpace; }
        }
        public NumericUpDown MaxCpuSize {
            get { return nudMaxAddrSpace; }
        }

        private void workingCycle_Click(object sender, EventArgs e) {
            /*MessageBox.Show("!!!!!");
            Model model = new Model();
            Settings settings = new Settings();
            settings.ValueOfRAMSize = 32000;
            settings.MinValueOfBurstTime = 3;
            settings.MaxValueOfBurstTime = 7;
            settings.Intensity = 0.9;
            IdGenerator id = new IdGenerator();
            for (int i = 0; i < 10; i++)
            {
                model.WorkingCycle();
                MessageBox.Show(model.cpu.IsFree().ToString());
               // MessageBox.Show(model.device.IsFree().ToString());
            }*/

            Model model = new Model();
            model.ModelSettings.Intensity = 0.8;
            model.ModelSettings.MinValueOfAddrSpace = 100;
            model.ModelSettings.MaxValueOfAddrSpace = 300;
            model.ModelSettings.MinValueOfBurstTime = 3;
            model.ModelSettings.MaxValueOfBurstTime = 7;
            model.ModelSettings.ValueOfRAMSize = 32000;
            model.SaveSettings();

            for(int i = 0; i < 20; i++) {
                model.WorkingCycle();
                if(model.Cpu.ActiveProcess != null) {
                    //Console.WriteLine("On cpu: {0}", model.Cpu.ActiveProcess);
                    // или для Windows Forms
                    MessageBox.Show("On cpu: " + model.Cpu.ActiveProcess.ToString());
                }
                if(model.ReadyQueue.Count != 0) {
                    //Console.WriteLine("Первый в очереди гоовых процессов: {0}", model.ReadyQueue.Item());
                    MessageBox.Show("Перший, в черзі готових процесів: " + model.ReadyQueue.Item());
                }
                if(model.Device.ActiveProcess != null) {
                    //Console.WriteLine("On device: {0}", model.Device.ActiveProcess);
                    // или для Windows Forms
                    MessageBox.Show("On device: " + model.Device.ActiveProcess.ToString());
                }
                if(model.DeviceQueue.Count != 0) {
                    //Console.WriteLine("Первый в очереди к внешнему устройству: {0}", model.DeviceQueue.Item());
                    MessageBox.Show("Первый в очереди к внешнему устройству: " + model.DeviceQueue.Item());
                }
            }

        }
    }
}
