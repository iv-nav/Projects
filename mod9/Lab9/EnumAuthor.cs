using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class EnumAuthor : IEnumerable, IEnumerator
    {
        int i = -1;
        Book[] data;

        internal EnumAuthor(Book[] books)
        {
            data = (Book[])books.Clone();
            Array.Sort(data, Book.ByAuthor());
        }

        public Book Current
        {
            get
            {
                return data[i];
            }
     
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        void IEnumerator.Reset()
        {
            i = -1;
        }



        bool IEnumerator.MoveNext()
        {
            i++;
            return (i < data.Length);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public EnumAuthor GetEnumerator()
        {
            return new EnumAuthor(data);
        }
    }
}
