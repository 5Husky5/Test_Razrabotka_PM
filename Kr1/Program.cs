using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Random random = new Random();
            int minx = 0;
            int maxx = 100;
            int miny = 0;
            int maxy = 100;

            double x1 = random.Next(minx, maxx + 1);
            double x2 = random.Next(minx, maxx + 1);
            double y1 = random.Next(minx, maxy + 1);
            double y2 = random.Next(minx, maxy + 1);

           
        }
    }
}
