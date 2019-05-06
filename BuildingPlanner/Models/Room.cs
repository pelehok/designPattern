using BuildingPlanner.Abstraction;

namespace BuildingPlanner.Models
{
	public class Room : Composite
	{
		public Room(Shape shape)
		{
			Shape = shape;
		}
		
		public override string ToString()
		{
			return $"Furniture square = {GetComponentSquare()}\r\n room square {Shape.Square}";
		}
	}
}