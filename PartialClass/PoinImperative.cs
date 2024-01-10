using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointImperative
{
    class point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        { 
            this.x = x;
            this.y = y;
        }

        public void MoveBy(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }
    class PointImperative
    {
        static void Main()
        {
            Point point = new Point(0, 0);
            point.MoveBy(100, 200);
        }
    }
}
