using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlannerUI.Models;
using Rectangle = PlannerUI.Models.Shapes.Rectangle;
using Component = PlannerUI.Abstraction.Component;

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
                                Location = new Point(0,0),
                                Height = flatPanel.Size.Height-1,
                                Width = flatPanel.Size.Width-1
                            };
            Flat = new Flat(flatShape);
            PrintTree();
            Draw();
        }

        private void PrintTree()
        {
            flatTree.Text = Flat.Display(1);
        }

        private void AddComponent(Flat c)
        {
            var component = Flat.GetComponentLieIn(c);
            var room = component as Flat;
            if (room != null)
            {
                component.Add(new Room(new Rectangle()
                {
                    Location = c.Rectangle.Location,
                    Height = c.Rectangle.Height,
                    Width = c.Rectangle.Width
                }));
            }
            else if(component is Room)
            {
                component.Add(new Furniture(new Rectangle()
                {
                    Location = c.Rectangle.Location,
                    Height = c.Rectangle.Height,
                    Width = c.Rectangle.Width
                }));
            }
            else
            {
                errorLds.Text = "You can't add this shape";
            }
            Draw();
            PrintTree();
        }

        private void Draw()
        {
            Graphics g = flatPanel.CreateGraphics();
            g.Clear(Color.AliceBlue);
            Flat.Draw(g);
        }

        //----------------------------------------------------------------

        private Point pointStart { get; set; }
        private Point pointEnd { get; set; }
        private void flatPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pointStart = new Point(e.X,e.Y);
            errorLds.Text = "";
        }

        private void flatPanel_MouseUp(object sender, MouseEventArgs e)
        {
            pointEnd = new Point(e.X, e.Y);
            AddComponent(new Flat(new Rectangle()
                                    {
                                        Location = pointStart,
                                        Height = pointEnd.Y-pointStart.Y,
                                        Width = pointEnd.X-pointStart.X
                                    }));
        }
    }
}
