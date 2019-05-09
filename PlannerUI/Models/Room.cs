using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerUI.Abstraction;

namespace PlannerUI.Models
{
    public class Room : Composite
    {
        public Room(IRectangle rectangle)
        {
            Rectangle = rectangle;
            name = "room";
        }
    }
}