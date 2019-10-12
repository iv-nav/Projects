using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace mod7
{
    class Program
    {
        static PropertyInfo[] getProp(object obj)
        {
            Type info = obj.GetType();
            PropertyInfo[] res = info.GetProperties();

            return res;

        }

        static void Main(string[] args)
        {

            string a = "hfdgg";
            PropertyInfo[] propertys = getProp(a);

            foreach (PropertyInfo prop in propertys)
                Console.WriteLine(prop);


            //var x = System.Double.;
            double x = 0.1;
            double y = 0.3;

            Console.WriteLine(ReferenceEquals(x.GetType(), y.GetType()));
            

            Console.ReadLine();

            
        }

        ~Program()
        {
           // File.AppendAllText("test.txt", "destruction ");
        }
    }
}
