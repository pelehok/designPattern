using System.Drawing;
using BuildingPlanner.Core.Models;
using Rectangle = BuildingPlanner.Core.Models.Rectangle;

namespace PlannerUI.UICompanents
{
    class FlatComponent : Flat
    {
        public Point Location { get; set; }
        public Rectangle Size { get; set; }

        public FlatComponent(Point location, Rectangle size) : base(size)
        {
            Location = location;
            Size = size;
        }

        public void DrawComponent(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Location.X, Location.Y,Size.Width,Size.Height);
        }
    }
}
