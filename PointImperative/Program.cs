using System;

namespace PointImperative
{
    class Point
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
            Console.WriteLine($"x:{point.x}, y:{point.y}");
        }
    }
}
