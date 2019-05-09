using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI.Abstraction
{
    public abstract class Component
    {
        public string name { get; set; }

        public abstract IRectangle Rectangle { get; set; }
        public abstract float Square { get; }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);

        public abstract bool IsComponentLieIn(Component c);

        public abstract string Display(int depth);
        public abstract void Draw(Graphics g);
    }
}
