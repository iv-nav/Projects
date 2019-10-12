using System;
using System.Collections;

namespace Lab9
{
    class Books 
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }

        public IEnumerable GetByAuthor()
        {
            return new EnumAuthor(books);
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)GetByAuthor();
        }

        public IEnumerable GetReverseEnum()
        {
            for (int i = books.Length - 1; i >= 0; --i)
            {
                yield return books[i];
            }
        }

    }
}
