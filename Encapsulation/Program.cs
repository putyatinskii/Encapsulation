using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fileIn = new StreamReader("input.txt", Encoding.GetEncoding(1251)))
            {         
                double x = double.Parse(fileIn.ReadLine());
                double y = double.Parse(fileIn.ReadLine());
                double radius = double.Parse(fileIn.ReadLine());

                Point p = new Point(x, y);
                Round r = Round.CreateRound(p, radius);
                Console.WriteLine(r);

                r.SetRadius(-2);
                Console.WriteLine(p);
                Console.WriteLine(r);

                Point p2 = r.Centre;
                p2.X = -100;
                p.Y = -10;

                Console.WriteLine("point1: {0}", p);
                Console.WriteLine("point2: {0}", p2);
                Console.WriteLine("point from circle: {0}", r.Centre);
                Console.WriteLine("Square: " + r.Square);
                Console.WriteLine("Length: " + r.Length);
                Console.ReadKey();
            }
        }
    }
}
