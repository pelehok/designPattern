using System.Drawing;

namespace PlannerUI.Abstraction
{
    public interface IRectangle : IShape
    {
        Point Location { get; }

        float Height { get; set; }
        float Width { get; set; }

        bool PointLieIn(Point p);
    }
}