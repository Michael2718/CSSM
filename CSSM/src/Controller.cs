namespace CSSM {
	class Controller {
		public static void Execute(ModelOperations operation, Model model) {
			switch (operation) {
				case ModelOperations.SaveSettings:
					model.SaveSettings();
					break;
				case ModelOperations.WorkingCycle:
					model.WorkingCycle();
					break;
				case ModelOperations.Clear:
					model.Clear();
					break;
				default:
					throw new ArgumentException(
						"Неизвестная операция: " + operation +
						"operation");
			}
		}
	}

}
