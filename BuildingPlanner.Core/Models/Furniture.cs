using BuildingPlanner.Core.Abstraction;

namespace BuildingPlanner.Core.Models
{
	public class Furniture : Composite
	{
		public Furniture(Shape shape)
		{
			Shape = shape;
            name = "furniture";
        }
	}
}