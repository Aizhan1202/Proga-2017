using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid2
{
    class Stars
    {
        public int x;
        public int y;
        public int height;
        public int width;
        public int dx;
        public int dy;
        public int cx;
        public int cy;
        public int rad;
        SolidBrush sb;

        public Stars (SolidBrush sb, int x, int y, int width, int height, int dx, int dy)
        {
            this.sb = sb;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dy = dy;
            this.dx = dx;
        }

        public Stars(SolidBrush sb, int x, int y, int width, int height)
        {
            this.sb = sb;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            rad = 10;
        }

        public void Drawst (PaintEventArgs e)
        {
            e.Graphics.FillEllipse(sb, x, y, width, height);
           
        }
        public void changeDir()
        {
            if (x + width > 608 || x < 0)
            {
                dx = dx * -1;
            }
            if (y + height > 374 || y < 0)
            {
                dy = dy * -1;
            }

            cx = x + width / 2;
            cy = y + height / 2;
            x += dx;
            y += dy;
        }
    }
}
