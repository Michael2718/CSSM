using Queues;
using System.ComponentModel;

namespace CSSM {
    class ViewDetailed : View {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm) : base(model, controller) {
            this.frm = frm;
        }

        public override void DataBind() {
            frm.LabelTime.DataBindings.Add(new Binding("Text", model.clock, "Clock"));
            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));
            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess"));

            frm.LabelOccupiedRAM.DataBindings.Add(new Binding("Text", model.ram, "OccupiedSize"));
            frm.LabelFreeRAM.DataBindings.Add(new Binding("Text", model.ram, "FreeSize"));

            Binding intestityBinding = new Binding("Value", model.ModelSettings, "Intensity");
            intestityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.ProcIntensity.DataBindings.Add(intestityBinding);

            Binding minBurstTimeBinding = new Binding("Value", model.ModelSettings, "MinBurstTime");
            minBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.MinBurstTime.DataBindings.Add(minBurstTimeBinding);

            Binding maxBurstTimeBinding = new Binding("Value", model.ModelSettings, "MaxBurstTime");
            maxBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.MaxBurstTime.DataBindings.Add(maxBurstTimeBinding);

            Binding ramSizeBinding = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize");
            //ramSizeBinding.Parse += new ConvertEventHandler(objectToInt);
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.RamSize.DataBindings.Add(ramSizeBinding);

            Binding minCpuSizeBinding = new Binding("Value", model.ModelSettings, "MinCpuSize");
            minCpuSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.MinCpuSize.DataBindings.Add(minCpuSizeBinding);

            Binding maxCpuSizeBinding = new Binding("Value", model.ModelSettings, "MaxCpuSize");
            maxCpuSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.MaxCpuSize.DataBindings.Add(maxCpuSizeBinding);

            Subscribe();
        }

        public override void DataUnbind() {
            frm.ProcIntensity.DataBindings.RemoveAt(0);
            frm.MinBurstTime.DataBindings.RemoveAt(0);
            frm.MaxBurstTime.DataBindings.RemoveAt(0);
            frm.MinCpuSize.DataBindings.RemoveAt(0);
            frm.MaxCpuSize.DataBindings.RemoveAt(0);
            frm.RamSize.DataBindings.RemoveAt(0);
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

