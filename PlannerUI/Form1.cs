using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingPlanner.Core.Models;
using Rectangle = BuildingPlanner.Core.Models.Rectangle;

namespace PlannerUI
{
    public partial class Form1 : Form
    {
        private Flat Flat { get; set; }

        public Form1()
        {
            InitializeComponent();
            var flatShape = new Rectangle()
            {
                Height = flatPanel.Size.Height,
                Width = flatPanel.Size.Width
            };
            Flat = new Flat(flatShape);
            DrawTree();
        }

        private void DrawTree()
        {
            flatTree.Text = Flat.Display(1);
        }

        private void AddComponent()
        {

        }

        //----------------------------------------------------------------

        private Point pointStart { get; set; }
        private Point pointEnd { get; set; }
        private void flatPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pointStart = new Point(e.X,e.Y);
        }

        private void flatPanel_MouseUp(object sender, MouseEventArgs e)
        {
            pointEnd = new Point(e.X, e.Y);
        }
    }
}
