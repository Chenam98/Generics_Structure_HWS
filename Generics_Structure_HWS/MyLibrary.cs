using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Structure_HWS
{
    public class Library
    {

        //Fields
        private Dictionary<string, Book> books;
        public int Count { get { return books.Count; } }


        //Ctor
        public Library()
        {
            books = new Dictionary<string, Book>();
        }


        //Methods
        public bool AddBook(Book book)
        {
            if (book == null || HaveThisBook(book.Title))
            {
                return false;
            }
            else
            {
                Console.WriteLine(book.Title);
                books.Add("1", book);
            }
            return true;
        }

        public bool RemoveBook(string rb)
        {
            if (HaveThisBook(rb))
            {
                books.Remove(rb);
                return true;
            }
            else
                return false;
        }

        public bool HaveThisBook(string htb)
        {
            if (books.ContainsKey(htb))
            {
                return true;
            }
            return false;
        }

        public Book GetBook(string gb)
        {
            if (HaveThisBook(gb))
                return books[gb];
            else
                return null;
        }

        public Book GetBookByAuthor(string gbba)
        {
            if (HaveThisBook(gbba))
                return books[gbba];
            else
                return null;
        }

        public void Clear()
        {
            books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> authors = new();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }
        public int BooksCount()
        {
            return books.Count;
        }


        public override string ToString()
        {
            string myStr = "";
            foreach (KeyValuePair<string, Book> keyValuePair in books)
            {
                myStr += keyValuePair.Key + keyValuePair.Value;
            }
            return myStr;
        }

    }
}

