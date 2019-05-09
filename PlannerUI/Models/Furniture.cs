using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerUI.Abstraction;

namespace PlannerUI.Models
{
    public class Furniture : Composite
    {
        public Furniture(IRectangle rectangle)
        {
            Rectangle = rectangle;
            name = "furniture";
        }
    }
}
