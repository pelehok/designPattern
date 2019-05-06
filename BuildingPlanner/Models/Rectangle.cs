using BuildingPlanner.Abstraction;

namespace BuildingPlanner.Models
{
	public class Rectangle : Shape
	{
		public double Height { get; set; }
		public double Width { get; set; }

		public double Square => Height * Width;
	}
}