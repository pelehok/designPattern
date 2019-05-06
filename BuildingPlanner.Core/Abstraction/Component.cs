namespace BuildingPlanner.Core.Abstraction
{
	public abstract class Component : Shape
	{
		public abstract void Add(Component c);
		public abstract void Remove(Component c);
		public abstract double Square { get; }
	}
}