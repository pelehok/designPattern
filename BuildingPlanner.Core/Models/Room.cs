using BuildingPlanner.Core.Abstraction;

namespace BuildingPlanner.Core.Models
{
	public class Room : Composite
	{
		public Room(Shape shape)
		{
			Shape = shape;
            name = "room";
        }
		
		public override string ToString()
		{
			return $"Furniture square = {GetComponentSquare()}\r\n room square {Shape.Square}";
		}
	}
}