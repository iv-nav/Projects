using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };

            //по идее вот так
            //Array.Reverse(array);

            //если Array использовать нельзя то я бы что нибудь такое сделал
            int j = array.GetLowerBound(0);
            int current;

            for (int i = array.GetLowerBound(0); i <= j; i++)
            {
                j = array.GetUpperBound(0) - i;
                current = array[i];

                array.SetValue(array[j], i);
                array.SetValue(current, j);
            }

            Console.ReadLine();

        }

    }
}


 
