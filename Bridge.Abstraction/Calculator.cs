namespace Bridge.Abstraction
{
	public class Calculator
	{
		public IOperation Operations;
		
		private IData inputData { get; set; }

		public Calculator(IData data)
		{
			inputData = data;
		}

		public double Calculate()
		{
			return Operations.Operation(inputData);
		}
	}
}