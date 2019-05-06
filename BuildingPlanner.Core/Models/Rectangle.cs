using BuildingPlanner.Core.Abstraction;

namespace BuildingPlanner.Core.Models
{
	public class Rectangle : Shape
	{
		public float Height { get; set; }
		public float Width { get; set; }

		public float Square => Height * Width;
	}
}