namespace Bridge.Abstraction
{
	public class Data : IData
	{
		public double Value1 { get; set; }
		public double Value2 { get; set; }

		public Data(double value1,double value2)
		{
			Value1 = value1;
			Value2 = value2;
		}

		public override string ToString()
		{
			return Value1 + " " + Value2;
		}
	}
}