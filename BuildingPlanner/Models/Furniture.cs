using BuildingPlanner.Abstraction;

namespace BuildingPlanner.Models
{
	public class Furniture : Composite
	{
		public Furniture(Shape shape)
		{
			Shape = shape;
		}
	}
}