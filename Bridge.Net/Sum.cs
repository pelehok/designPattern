using Bridge.Abstraction;

namespace Bridge.Net
{
	public class Sum : IOperation
	{
		public double Operation(IData inputData)
		{
			return inputData.Value1 + inputData.Value2;
		}
	}
}