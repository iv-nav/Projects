using System;


namespace Geometry
{
    class Circle : Shape 
    {
        //Fdata fd;

        public double r
        {
            get { return fd.a; }
            set { fd.a=fd.b=value; }
        }

        public Circle(Fdata fd)
        {
            this.fd = fd;
            this.fd.b = this.fd.a;
            this.fd.type = Figures.Circle;
        }

        public override double Area()
        {
            return Math.PI*r*r;
        }

        //public void Move(int dx, int dy)
        //{
        //    fd.x0 += dx;
        //    fd.y0 += dy;
        //}
        public new void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" r=" + r);
        }
    }
}
