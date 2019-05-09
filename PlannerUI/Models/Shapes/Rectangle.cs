using System;
using System.Collections.Generic;
using System.Drawing;
using PlannerUI.Abstraction;

namespace PlannerUI.Models.Shapes
{
    public class Rectangle : IRectangle
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public Point Location { get; set; }

        public float Square => Height * Width;

        public bool PointLieIn(Point p)
        {
            var rectPoint = GetRectanglePoint();
            float suma = 0f;
            for (int i = 0; i < 3; i++)
            {
                var triangle = new Triangle(){Point = new List<Point>()
                    {
                        rectPoint[i],
                        rectPoint[i+1],
                        p
                    }};
                suma += triangle.Square;
            }

            var lastTriangle = new Triangle()
                                {
                                    Point = new List<Point>()
                                    {
                                        rectPoint[rectPoint.Count-1],
                                        rectPoint[0],
                                        p
                                    }
                                };
            suma += lastTriangle.Square;

            return Math.Abs(suma - this.Square) < 0.1;
        }

        private List<Point> GetRectanglePoint()
        {
            return new List<Point>()
            {
                new Point(Location.X, Location.Y),
                new Point(Location.X+ (int)Width, Location.Y),
                new Point(Location.X + (int)Width, Location.Y + (int) Height),
                new Point(Location.X, Location.Y + (int) Height)
            };
        }
    }
}