using System;

namespace WrapperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Wclass wrapper = new Wclass(new char[] { 'a', 'b', 'c' });

            Console.WriteLine(wrapper);

            Console.ReadKey();
        }

        public class Wclass
        {
            private char[] _chars;

            public Wclass(char[] chars)
            {
                _chars = new char[chars.Length];

                Array.Copy(chars, _chars, chars.Length);
            }

            public override string ToString()
            {
                return new String(_chars);
            }
        }
    }
}
