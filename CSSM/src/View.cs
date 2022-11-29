namespace CSSM {
	abstract class View : IDisposable {
        public readonly Model model;
        public View(Model model, Controller controller) {
			this.model = model;
			Controller = controller;
		}
		public Controller Controller { private get; set; }
		public void ReactToUserActions(ModelOperations modelOperation) {
            Controller.Execute(modelOperation, model);
		}
		public void Dispose() {
			DataUnbind();
		}
		abstract public void DataBind();
		abstract public void DataUnbind();
	}
}
