using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingPlanner.Core.Abstraction;
using Rectangle = BuildingPlanner.Core.Models.Rectangle;

namespace PlannerUI.UICompanents
{
    class UIComponent : Component
    {
        List<UIComponent> _uiComponents = new List<UIComponent>();

        public Point Location { get; set; }
        public Rectangle Size { get; set; }

        public void DrawComponent(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Location.X, Location.Y, Size.Width, Size.Height);
        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }

        public override float Square { get; }
        public override string Display(int depth)
        {
            throw new NotImplementedException();
        }
    }
}
