namespace BuildingPlanner.Core.Abstraction
{
	public abstract class Component : Shape
	{
        protected string name;

        public abstract void Add(Component c);
		public abstract void Remove(Component c);
		public abstract float Square { get; }
        
        public abstract string Display(int depth);
    }
}