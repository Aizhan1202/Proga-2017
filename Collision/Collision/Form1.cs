using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collision
{
    public partial class Frame : Form
    {

        Ellipse ellipse1 = new Ellipse(0, 10, 50, 50, new SolidBrush(Color.Red), 15, 15);
        Rectangle rectangle1 = new Rectangle(150, 10, 50, 50, new SolidBrush(Color.Blue), -10, 6);


        public Frame()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 100;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ellipse1.x + ellipse1.width > 286 || ellipse1.x < 0)
            {
                ellipse1.dx *= -1;
            }

            if (ellipse1.y + ellipse1.height > 263 || ellipse1.y < 0)
            {
                ellipse1.dy *= -1;
            }

            ellipse1.y += ellipse1.dy;
            ellipse1.x += ellipse1.dx;

            if (rectangle1.x + rectangle1.width > 286 || rectangle1.x < 0)
            {
                rectangle1.dx *= -1;
            }

            if (rectangle1.y + rectangle1.height > 263 || rectangle1.y < 0)
            {
                rectangle1.dy *= -1;
            }

            if (rectangle1.DistanceBetweenCenters(ellipse1.getCenterPoint()) < (rectangle1.width/2+ellipse1.width/2)/2 ||
                 (rectangle1.DistanceBetweenCenters(ellipse1.getCenterPoint()) < (rectangle1.height/2+ellipse1.height/2)/2)
                )
            {
                rectangle1.dx *= -1;
                ellipse1.dx *= -1;
            }

            rectangle1.y += rectangle1.dy;
            rectangle1.x += rectangle1.dx;

            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ellipse1.Draw(e);
            rectangle1.Draw(e);
        }
    }
}
