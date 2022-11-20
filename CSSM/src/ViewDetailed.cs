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

			Binding intestityBinding = new Binding("Value", model.ModelSettings, "Intensity");
			intestityBinding.ControlUpdateMode = ControlUpdateMode.Never;
			frm.NudProcIntensity.DataBindings.Add(intestityBinding);

			Binding minBurstTimeBinding = new Binding("Value", model.ModelSettings, "MinBurstTime");
			minBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
			frm.NudMinBurstTime.DataBindings.Add(minBurstTimeBinding);

			Binding maxBurstTimeBinding = new Binding("Value", model.ModelSettings, "MaxBurstTime");
			maxBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
			frm.NudMaxBurstTime.DataBindings.Add(maxBurstTimeBinding);

			Binding ramSizeBinding = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize");
			ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
			frm.CbRamSize.DataBindings.Add(ramSizeBinding);

			Binding minAddrSpaceBinding = new Binding("Value", model.ModelSettings, "MinCpuSize");
			minAddrSpaceBinding.ControlUpdateMode = ControlUpdateMode.Never;
			frm.NudMinAddrSpace.DataBindings.Add(minAddrSpaceBinding);

			Binding maxAddrSpaceBinding = new Binding("Value", model.ModelSettings, "MaxCpuSize");
			maxAddrSpaceBinding.ControlUpdateMode = ControlUpdateMode.Never;
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
		private void PropertyChangedHandler(object? sender, PropertyChangedEventArgs e) {
			/*            if(e.PropertyName == "ReadyQueue") {
							SortedUnsorterQueue<Process> temp = (SortedUnsorterQueue<Process>)model.ReadyQueue;
							updateListBox(temp.Sorted, frm.LblSortedCPUQueue);
							updateListBox(temp.Unsorted, frm.LblUnsortedCPUQueue);
						} else {
							updateListBox(model.DeviceQueue, frm.LblDeviceQueue);
							updateListBox(model.DeviceQueue_2, frm.LblDeviceQueue_2);
						}*/
		}

		private void UpdateListBox(IQueueable<Process> queue, ListBox lb) { }
		private FrmDetailed frm;
	}

}

