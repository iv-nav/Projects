using System;
using System.Text;

namespace Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Panda p1 = new Panda("Панда Ди");
            //Panda p2 = new Panda("Панда Да");

            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p2.Name);
            //Console.WriteLine(Panda.Population);
            ///////////////////////////////////////
            //int a = 1234;
            //long b = a;
            //short c = (short)a;

            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //Console.WriteLine(Math.Pow(2, 32) - 1);
            //////////////////////////////////////
            //Name name = new Name();
            //name.name = "Иван";
            //name.patronymic = "Вадимович";
            //name.familyName = "Навроцкий";

            //Console.WriteLine($"{name.name} {name.patronymic} {name.familyName}");

            //Point p1 = new Point();
            //p1.X = 7;
            //p1.Text = "I`m the first point";
            //Point p2 = p1;

            //p1.X = 9;

            //Console.WriteLine(p1.X);

            //Console.WriteLine(p2.X);

            //Console.WriteLine(p1.Text);
            //Console.WriteLine(p2.Text);
            //p2.Text = "I`m the second point";

            //Console.WriteLine(p1.Text);
            //Console.WriteLine(p2.Text);

            //Point p = null; //non Nullable if Struct
            //Console.WriteLine(p.X); //NullReferenceException if Class

            //int a = 0x7f;
            //Console.WriteLine(a); //127

            //var b = 3.5M;
            //Console.WriteLine(b.GetType());

            //float f = 4.5F;
            //decimal d = -124M;

            //long x = 45132;
            //float y = (float)x;

            //Console.WriteLine(y);

            //int z = (int)y;

            //Console.WriteLine(z);

            //short u = (short)z;
            //long p = z;

            //short a = 10;
            //short b = 20;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //int a = Int32.MinValue;

            //Console.WriteLine(--a);

            //if (a == int.MaxValue)
            //    Console.WriteLine("true");

            //Console.WriteLine(Double.PositiveInfinity);

            //Console.WriteLine("2" + 4);
            //Console.WriteLine(4 + '2'); //4 + 50 (код символа)
            //Console.WriteLine((4 + '2').GetType());

            //Console.WriteLine('\u00A9'); //copyright

            //char copyRight = '\u00A9';

            //Console.WriteLine("lkjhglkjsfghl \t kjhglkhglskjhg \n yrtfjkhjqerhkqkj");
            //Console.WriteLine($@"jhfljegfehrg \t fhgjhfhwerkgfk \n fhwegfhweqgkhqgw   {{{copyRight}}}");

            //StringBuilder str = new StringBuilder();

            //str.Append("Hello World!");

            //Console.WriteLine(str.ToString());

            //int[,] matrix = new int[,] //Прямоугльный массив
            //    {
            //        {0,1,2},
            //        {3,4,5},
            //        {6,7,8}
            //    };

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //        Console.WriteLine(matrix[i, j]);

            int[][] matrix = new int[][] //Зубчатый массив
                {
                    new int [] { 0, 1, 2},
                    new int [] { 3, 4, 5},
                    new int [] { 6, 7, 8, 9}
                };

            Console.ReadKey();

        }

        public struct Point { public int X; public int Y; public string Text; }

        //public class Point
        //{
        //    public int X;
        //    public int Y;
        //    public string Text;
        //}

        public struct Name
        {
            public string name;
            public string patronymic;
            public string familyName;
        }

        public class Panda
        {
            public string Name;
            public static int Population;

            public Panda(string name)
            {
                Name = name;
                Population++;
            }
        }
    }
}
