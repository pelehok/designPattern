using System;
using System.Collections.Generic;

namespace BuildingPlanner.Core.Abstraction
{
	public abstract class Composite : Component
	{
		protected List<Component> _components = new List<Component>();
		protected Shape Shape { get; set; }
		
		public override float Square => Shape.Square;
		
		public override void Add(Component c)
		{
			_components.Add(c);
		}

		public override void Remove(Component c)
		{
			_components.Remove(c);
		}
		
		protected double GetComponentSquare()
		{
			var roomsSquare = 0.0;
			foreach (var room in _components)
			{
				roomsSquare += room.Square;
			}

			return roomsSquare;
		}

        public override string Display(int depth)
        {
            string display = "";

            display = new String('*', depth) +" "+ name+"\r\n";
            foreach (Component component in _components)
            {
                display += (component.Display(depth + 2)+ "\r\n");
            }

            return display;
        }
    }
}