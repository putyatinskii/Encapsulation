using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Round
    {
        private Point centre = new Point(0, 0);
        private double radius = 1;

        private Round(Point centre, double radius)
        {
            this.centre = new Point(centre);
            this.radius = radius;
        }

        private double Radius { get => radius; set => radius = value; }

        public Point Centre { get => new Point(centre); set => centre = new Point(value); }

        public double Square
        {
            get
            {
                return Math.PI * radius * radius;
            } 
        }

        public double Length
        {
            get
            {
                return Math.PI * 2 * radius;
            }
        }

        public override string ToString()
        {
            return "Round with radius = " + radius + ", centre in " + centre;
        }

        public static Round CreateRound(Point p, double r)
        {
            try
            {
                if (r > 0)
                {
                    return new Round(p, r);
                }
                else
                {
                    throw new ArgumentException("You trying to set negative value (radius = " + r + ")");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return new Round(p, -r);
            }
        }

        public void SetRadius(double r)
        {
            try
            {
                if (r > 0)
                {
                    Radius = r;
                }
                else
                {
                    throw new ArgumentException("You trying to set negative value (radius = " + r + ")");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Radius = -r;
            }
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}
