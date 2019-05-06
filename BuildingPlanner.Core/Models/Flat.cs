using BuildingPlanner.Core.Abstraction;

namespace BuildingPlanner.Core.Models
{
	public class Flat : Composite
	{
		public Flat(Shape shape)
		{
			Shape = shape;
            name = "flat";
        }
		
		public override string ToString()
		{
			return $"Rooms square = {GetComponentSquare()}\r\n flat square {Shape.Square}";
		}
	}
}