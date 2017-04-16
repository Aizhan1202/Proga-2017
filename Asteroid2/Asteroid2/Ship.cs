using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid2
{
    class Ship
    {
        public int x;
        public int y;
        public int dx;
        public int dy;
        public int cx;
        public int cy; 
        public int rad;
        SolidBrush sb;
        public Point[] sh = new Point[6];

        public Ship (SolidBrush sb, int x, int y  ,int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.sb = sb;

            sh[0].X = x;
            sh[0].Y = y;
            sh[1].X = x;
            sh[1].Y = y - 30;
            sh[2].X = x + 30;
            sh[2].Y = y - 50;
            sh[3].X = x + 60;
            sh[3].Y = y - 30;
            sh[4].X = x + 60;
            sh[4].Y = y;
            sh[5].X = x + 30;
            sh[5].Y = y + 20;
            cx = x + 15;
            cy = y - 7;

        }

        public void Drawash(PaintEventArgs e)
        {
            e.Graphics.FillPolygon(sb, sh);
        }

        public void move()
        {
            if (x + 25 > 608 || x - 5 < 0)
            {
                dx = dx * -1;
            }
            if (y + 20 > 374 || y - 20 < 0)
            {
                dy = dy * -1;
            }

            x += dx;
            y += dy;
            sh[0].X = x;
            sh[0].Y = y;
            sh[1].X = x ;
            sh[1].Y = y - 15;
            sh[2].X = x + 15;
            sh[2].Y = y - 25;
            sh[3].X = x + 30;
            sh[3].Y = y - 15;
            sh[4].X = x + 30;
            sh[4].Y = y;
            sh[5].X = x + 15;
            sh[5].Y = y + 10;
            cx = x + 15;
            cy = y - 7;
            rad = 15;
            
            
        }
       
    }
}
