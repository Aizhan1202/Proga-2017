using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collision
{
    class Rectangle
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int dx;
        public int dy;
        SolidBrush sb;
        PointF center;

        public Rectangle (int x, int y, int width, int height, SolidBrush sb, int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.sb = sb;
            this.dx = dx;
            this.dy = dy;
        }
        public void Draw(PaintEventArgs e)
        {
            
            e.Graphics.FillRectangle(sb, x, y, width, height);
        }

        public PointF getCenterPoint()
        {
            return new PointF((x + width) / 2, (y + height) / 2);
        }

        public double DistanceBetweenCenters(PointF inCenter)
        {
            center = getCenterPoint();

            return Math.Sqrt((center.X - inCenter.X) * (center.X - inCenter.X) + (center.Y - inCenter.Y) * (center.Y - inCenter.Y));
        }
    }
}
