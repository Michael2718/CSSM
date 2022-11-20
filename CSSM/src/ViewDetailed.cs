using Queues;
using System.ComponentModel;

namespace CSSM {
	class ViewDetailed : View {
		public ViewDetailed(Model model, Controller controller, FrmDetailed frm) : base(model, controller) {
			this.frm = frm;
		}

		public override void DataBind() {
			frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));

			frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));

			frm.TbDevice1.DataBindings.Add(new Binding("Text", model.Device1, "ActiveProcess"));
			frm.TbDevice2.DataBindings.Add(new Binding("Text", model.Device2, "ActiveProcess"));
			frm.TbDevice3.DataBindings.Add(new Binding("Text", model.Device3, "ActiveProcess"));

			frm.LblFreeRam.DataBindings.Add(new Binding("Text", model.Ram, "FreeSize"));
			frm.LblOccupiedRam.DataBindings.Add(new Binding("Text", model.Ram, "OccupiedSize"));

			Binding intestityBinding = new("Value", model.ModelSettings, "Intensity") {
				ControlUpdateMode = ControlUpdateMode.Never
			};
			frm.NudProcIntensity.DataBindings.Add(intestityBinding);

			Binding minBurstTimeBinding = new("Value", model.ModelSettings, "MinBurstTime") {
				ControlUpdateMode = ControlUpdateMode.Never
			};
			frm.NudMinBurstTime.DataBindings.Add(minBurstTimeBinding);

			Binding maxBurstTimeBinding = new("Value", model.ModelSettings, "MaxBurstTime") {
				ControlUpdateMode = ControlUpdateMode.Never
			};
			frm.NudMaxBurstTime.DataBindings.Add(maxBurstTimeBinding);

			Binding ramSizeBinding = new("SelectedItem", model.ModelSettings, "RamSize") {
				ControlUpdateMode = ControlUpdateMode.Never
			};
			frm.CbRamSize.DataBindings.Add(ramSizeBinding);

			Binding minAddrSpaceBinding = new("Value", model.ModelSettings, "MinAddrSpace") {
				ControlUpdateMode = ControlUpdateMode.Never
			};
			frm.NudMinAddrSpace.DataBindings.Add(minAddrSpaceBinding);

			Binding maxAddrSpaceBinding = new("Value", model.ModelSettings, "MaxAddrSpace") {
				ControlUpdateMode = ControlUpdateMode.Never
			};
			frm.NudMaxAddrSpace.DataBindings.Add(maxAddrSpaceBinding);

			Subscribe();
		}

		public override void DataUnbind() {
			frm.NudProcIntensity.DataBindings.RemoveAt(0);
			frm.NudMinBurstTime.DataBindings.RemoveAt(0);
			frm.NudMaxBurstTime.DataBindings.RemoveAt(0);
			frm.CbRamSize.DataBindings.RemoveAt(0);
			frm.NudMinAddrSpace.DataBindings.RemoveAt(0);
			frm.NudMaxAddrSpace.DataBindings.RemoveAt(0);

			Unsubscribe();
		}
		private void Subscribe() {
			model.PropertyChanged += PropertyChangedHandler;
		}
		private void Unsubscribe() {
			model.PropertyChanged -= PropertyChangedHandler;
		}
		private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "ReadyQueue")
                updateListBox(model.ReadyQueue, frm.LbCPUQueue);
            else {
                updateListBox(model.DeviceQueue1, frm.LbDeviceQueue1);
                updateListBox(model.DeviceQueue2, frm.LbDeviceQueue2);
                updateListBox(model.DeviceQueue3, frm.LbDeviceQueue3);
            }
        }

        private void updateListBox(IQueueable<Process> queue, ListBox lb) {
            lb.Items.Clear();
			if (queue.Count != 0) {
				lb.Items.AddRange(queue.ToArray());
			}
        }

        private readonly FrmDetailed frm;
	}

}

