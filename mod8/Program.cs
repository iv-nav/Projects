using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod8
{
    class Program
    {
        static void Main(string[] args)
        {
            //long fac = 0;
            //bool res = factorial(2016, out fac);

            //Console.WriteLine(fac);
            

            Console.WriteLine(fullFactorial(2016));
            Console.ReadLine();
        }

        public static bool factorial(int n, out long fac)
        {
            fac = 1;

            for (int i = 1; i <= n; ++i)
            {
                try
                {
                    fac = checked(fac * i);
                    //fac *= i;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }

            }
            return true;
        }

        public static BigInteger fullFactorial(int n)
        {
            BigInteger ffac = n;

            for (int i = 1; i <= n; ++i)
            {
                ffac *= i;
            }

            return ffac;
        }
    }

}
