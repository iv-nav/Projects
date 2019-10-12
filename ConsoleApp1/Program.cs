using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Figures
{
    Romb, 
    Circle,
    Rect
}

struct Fdata
{
    public int x0, y0;      // координаты центра тяжести
    public int color;       // цвет фигуры
    public Figures type;	// тип фигуры

}


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fdata fd = new Fdata() { x0 = 1, y0 = 1, color = 0x2727FF, type = Figures.Rect };
            //int n;

            //Console.WriteLine(area(fd));

            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ffactorial(n));
            int res = 0;
            int n = 0;

            foreach(string arg in args)
            {
                if (int.TryParse(arg, out n))

                res += n;
                //Console.WriteLine(arg);
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }

        static double area(Fdata fd)
        {
            double res = 0;

            switch (fd.type)
            {
                case Figures.Romb:
                    res = 1;
                    break;

                case Figures.Circle:
                    res = 2;
                    break;

                default:
                    res = 3;
                    break;
            }


            return res;
        }

        static long ffactorial(int n)
        {
            long res = 1;

            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }

            return res;
        }

        static void Swap(params object[] args)
        {
            for (int i = 0; i < 10; i++)
            {
            }

            do
            {
           
            }
            while (true);
        }
    }
}
