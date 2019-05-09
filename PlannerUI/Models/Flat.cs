using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerUI.Abstraction;

namespace PlannerUI.Models
{
    public class Flat : Composite
    {
        public Flat(IRectangle rectangle)
        {
            Rectangle = rectangle;
            name = "flat";
        }
    }
}