using Bridge.Abstraction;

namespace Bridge.Net
{
	public class Subtract: IOperation
	{
		public double Operation(IData inputData)
		{
			return inputData.Value1 - inputData.Value2;
		}
	}
}