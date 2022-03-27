using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics_Structure_HWS
{
    public class Book
    {
        private BookStory bookStory;
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string author, string category)
        {
            Title = title;
            Content = bookStory.BookText(this);
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        private class BookStory
        {
            public string Tomorrowland = "Tomorrowland is a Belgian electronic dance music festival " +
                                         "held in Boom, Flanders, Belgium since 2005";


            public string UMF = "Ultra Music Festival is an annual outdoor electronic music festival " +
                                " that takes place during March in Miami, Florida, United States." +
                                "The festival was founded in 1999 by Russell Faibisch and Alex Omes" +
                                " and is named after the Ultra Music label";

            public string EDC = "Electric Daisy Carnival, commonly known as EDC," +
                                " is the largest electronic dance music festival in North America." +
                                " The annual flagship event is now held in May," +
                                " at the Las Vegas Motor Speedway and Orlando";


            public string BookText(Book book)
            {
                if (book.Title == "Tomorrowland")
                {
                    return Tomorrowland;
                }
                if (book.Title == "UMF")
                {
                    return UMF;
                }
                if (book.Title == "EDC")
                {
                    return EDC;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}