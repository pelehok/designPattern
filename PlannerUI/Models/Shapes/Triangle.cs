using System;
using System.Collections.Generic;
using System.Drawing;
using PlannerUI.Abstraction;

namespace PlannerUI.Models.Shapes
{
    class Triangle : IShape  
    {
        public List<Point> Point { get; set; }

        public float Square => GetSquare();

        private float GetSquare()
        {
            var t1 = Point[1].Y - Point[2].Y;
            var t2 = Point[2].Y - Point[0].Y;
            var t3 = Point[0].Y - Point[1].Y;

            return Math.Abs(Point[0].X * t1 + Point[1].X * t2 + Point[2].X * t3) / 2.0f;
        }
    }
}
