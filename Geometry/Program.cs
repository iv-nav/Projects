using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    class Tea 
    {
        public Color TColor { get; set; }
        public float Tempr { get; set; }
        public readonly int n;

        public Tea(Color c, float t = 95.5f)
        {
            TColor = c;
            Tempr = t;

            n = (int)Tempr / 10;

        }

        public Tea() : this(Color.Black, 95.5f) { }
        //{
        //    TColor = Color.Black;
        //    Tempr = 95.5f;
        //}

        public Tea Warm(float dt)
        {
            Tempr += dt;

            return this;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea1 = new Tea();
            Tea tea2 = new Tea(Color.Green, 80);
            Tea tea3 = new Tea() { TColor = Color.Red, Tempr = 85};


            tea2.Warm(-20).Warm(-5);

            Tea[] t = new Tea[] {tea1, tea2, tea3};

            Console.WriteLine(tea2.TColor + " " + tea2.Tempr);
            Console.ReadLine();

        }
    }
}
