using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI.Abstraction
{
    public class Composite : Component
    {
        protected List<Component> _components = new List<Component>();
        public override IRectangle Rectangle { get; set; }

        public override float Square => Rectangle.Square;

        public override void Add(Component c)
        {
            c.name += (_components.Count + 1).ToString();
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

        public override bool IsComponentLieIn(Component c)
        {
            return Rectangle.PointLieIn(c.Rectangle.Location) &&
                   Rectangle.PointLieIn(
                       new Point(
                           c.Rectangle.Location.X + (int)c.Rectangle.Width,
                           c.Rectangle.Location.Y + (int)c.Rectangle.Height
                           ));
        }

        public Component GetComponentLieIn(Component c)
        {
            foreach (var component in _components)
            {
                if (component.IsComponentLieIn(c))
                    return component;
            }
            if (this.IsComponentLieIn(c))
            {
                return this;
            }

            return null;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, this.Rectangle.Location.X, this.Rectangle.Location.Y, this.Rectangle.Width,
                this.Rectangle.Height);
            foreach (var component in _components)
            {
                component.Draw(g);
            }
        }

        public override string Display(int depth)
        {
            string display = "";

            display = new String('*', depth) + " " + name + "\r\n";
            foreach (Component component in _components)
            {
                display += (component.Display(depth + 1));
            }

            return display;
        }
    }
}