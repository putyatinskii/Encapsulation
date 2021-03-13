using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point point)
        {
            this.x = point.X;
            this.y = point.Y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public override string ToString()
        {
            return "Location: (" + x + ", " + y + ")";
        }
    }
}
