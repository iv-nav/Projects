using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Shape
    {
        protected Fdata fd;

        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }

        public virtual double Area()
        {
            return 0;
        }

        public void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            //Console.WriteLine(" r=" + r);
        }
    }
}
