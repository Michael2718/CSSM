using Timer = System.Windows.Forms.Timer;

namespace CSSM {
	public partial class FrmDetailed : Form {
        private readonly ViewDetailed viewDetailed;

        public TextBox TbCPU => tbCPU;
		public TextBox TbDevice1 => tbDevice1;
		public TextBox TbDevice2 => tbDevice2;
		public TextBox TbDevice3 => tbDevice3;
        public ListBox LbCPUQueue => lbCPUQueue;
        public ListBox LbDeviceQueue1 => lbDeviceQueue1;
		public ListBox LbDeviceQueue2 => lbDeviceQueue2;
		public ListBox LbDeviceQueue3 => lbDeviceQueue3;

		public NumericUpDown NudProcIntensity => nudProcIntensity;
		public NumericUpDown NudMinBurstTime => nudMinBurstTime;
		public NumericUpDown NudMaxBurstTime => nudMaxBurstTime;
		public ComboBox CbRamSize => cbRamSize;
		public NumericUpDown NudMinAddrSpace => nudMinAddrSpace;
		public NumericUpDown NudMaxAddrSpace => nudMaxAddrSpace;

		public Label LblTime => lblTime;
		public Label LblFreeRam => lblFreeRam;
		public Label LblOccupiedRam => lblOccupiedRam;
        public Label LblCPUUtilization => lblCPUUtilization;
        public Label LblThroughput => lblThroughput;

        public FrmDetailed() {
            InitializeComponent();
            cbRamSize.SelectedItem = cbRamSize.Items[0];
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
        }
        private void BSaveSettings_Click(object? sender, EventArgs e) {
			SessionPreparation();
			viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
			if (rbAutoMode.Checked) {
                timerAutoMode = new Timer {
                    Enabled = true,
                    Interval = 1000
                };
                timerAutoMode.Tick += BWorkingCycle_Click;
			}
		}
		private void BWorkingCycle_Click(object? sender, EventArgs e) {
			viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
		}
		private void BClear_Click(object? sender, EventArgs e) {
			if (rbAutoMode.Checked) {
				timerAutoMode.Enabled = false;
			}
			viewDetailed.ReactToUserActions(ModelOperations.Clear);
			EndOfSession();
			UpdateSettings();
		}
		private void SessionPreparation() {
			bSaveSettings.Enabled = false;
			bClear.Enabled = true;
			bWorkingCycle.Enabled = rbManualMode.Checked;

			nudProcIntensity.Enabled = false;
			nudMinBurstTime.Enabled = false;
			nudMaxBurstTime.Enabled = false;
			cbRamSize.Enabled = false;
			nudMinAddrSpace.Enabled = false;
			nudMaxAddrSpace.Enabled = false;

			rbAutoMode.Enabled = rbAutoMode.Checked;
			rbManualMode.Enabled = rbManualMode.Checked;
		}
		private void UpdateSettings() {
			nudProcIntensity.Value = (decimal)0.5;
			nudMinBurstTime.Value = 1;
			nudMaxBurstTime.Value = 4;
			cbRamSize.SelectedItem = cbRamSize.Items[0];
			nudMinAddrSpace.Value = 100;
			nudMaxAddrSpace.Value = 260;
		}
		private void EndOfSession() {
			bClear.Enabled = false;
			bSaveSettings.Enabled = true;
			bWorkingCycle.Enabled = false;

			nudProcIntensity.Enabled = true;
			nudMinBurstTime.Enabled = true;
			nudMaxBurstTime.Enabled = true;
			cbRamSize.Enabled = true;
			nudMinAddrSpace.Enabled = true;
			nudMaxAddrSpace.Enabled = true;

			rbManualMode.Enabled = true;
			rbAutoMode.Enabled = true;
        }
    }
}
