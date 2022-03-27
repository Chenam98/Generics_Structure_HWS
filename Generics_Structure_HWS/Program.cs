using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics_Structure_HWS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            books.Add(1, new Book("Tomorrowland", "Tl", "A"));
            books.Add(2, new Book("UMF", "ULTRA", "B"));
            books.Add(3, new Book("EDC", "EDCMF", "C"));
        }
    }
}