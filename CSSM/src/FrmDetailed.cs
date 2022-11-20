using Timer = System.Windows.Forms.Timer;

namespace CSSM {
	public partial class FrmDetailed : Form {
		private ViewDetailed viewDetailed;
		public FrmDetailed() {
			InitializeComponent();
			cbRamSize.SelectedItem = cbRamSize.Items[0];
			viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
			viewDetailed.DataBind();
		}

		public TextBox TbCPU => tbCPU;
		public ListBox LblCPUQueue => lblCPUQueue;
		public TextBox TbDevice1 => tbDevice1;
		public TextBox TbDevice2 => tbDevice2;
		public TextBox TbDevice3 => tbDevice3;
		public ListBox LblDeviceQueue1 => lblDeviceQueue1;
		public ListBox LblDeviceQueue2 => lblDeviceQueue2;
		public ListBox LblDeviceQueue3 => lblDeviceQueue3;

		public NumericUpDown NudProcIntensity => nudProcIntensity;
		public NumericUpDown NudMinBurstTime => nudMinBurstTime;
		public NumericUpDown NudMaxBurstTime => nudMaxBurstTime;
		public ComboBox CbRamSize => cbRamSize;
		public NumericUpDown NudMinAddrSpace => nudMinAddrSpace;
		public NumericUpDown NudMaxAddrSpace => nudMaxAddrSpace;

		public Label LblTime => lblTime;
		public Label LblFreeRam => lblFreeRam;
		public Label LblOccupiedRam => lblOccupiedRam;

		private void bSaveSettings_Click(object sender, EventArgs e) {
			sessionPreparation();
			viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
			if (rbAutoMode.Checked) {
				timerAutoMode = new Timer();
				timerAutoMode.Enabled = true;
				timerAutoMode.Interval = 1000;
				timerAutoMode.Tick += bWorkingCycle_Click;
			}
		}
		private void bWorkingCycle_Click(object sender, EventArgs e) {
			viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
		}
		private void bClear_Click(object sender, EventArgs e) {
			if (rbAutoMode.Checked) {
				timerAutoMode.Enabled = false;
			}
			viewDetailed.ReactToUserActions(ModelOperations.Clear);
			endOfSession();
			UpdateSettings();
		}
		private void sessionPreparation() {
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
			nudMinAddrSpace.Value = 25;
			nudMaxAddrSpace.Value = 125;
		}
		private void endOfSession() {
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
