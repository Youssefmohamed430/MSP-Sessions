using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Three
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        //{
        //    get { return Price; }
        //    set 
        //    {
        //        if (Price < 0) return;
        //    }
        //}

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Price = 0;
        }

        public Book(string title, string author,decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"the title is {this.Title}, author is {this.Author} and price is {this.Price}");
        }
    }
}
