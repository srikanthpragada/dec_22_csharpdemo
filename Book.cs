using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class TestBook
    {
        public static void Main()
        {
            Book b = new Book("C# Comp. Ref.", 550);
            b[0] = "Introduction";
            b[1] = "OOP";
            b[2] = "Library";

            b.Print();

            Book.TaxRate = 12.5;
            Console.WriteLine(b.SellingPrice);

            Book b2 = new Book("Asp.Net Unleashed", 800, "HTML", "Web Forms", "AJAX");
            b2[3] = "ADO.NET";
            b2.Print(); 
        }
    }
    class Book
    {
        private string title;
        private int price;
        private string[] chapters; 
        private static double taxrate = 10.5;

        public static double TaxRate
        {
            get
            {
                return taxrate;
            }
            set
            {
                taxrate = value; 
            }
        }


        public Book(string title, int price , params string [] chapters)
        {
            this.title = title;
            this.price = price;
            this.chapters = new string[20];
            int i = 0;
            foreach(string ch in chapters)
            {
                this.chapters[i] = ch;
                i++;
            }
        }

        public  string Title
        {
            get
            {
                return title; 
            }
        }

        public double SellingPrice
        {
            get
            {
                return price + (price * taxrate / 100);
            }
        }

        public string this[int index]
        {
            get
            {
                return chapters[index];
            }
            set
            {
                chapters[index] = value; 
            }
        }

        public void Print()
        {
            Console.WriteLine(title);
            Console.WriteLine(price);
            foreach(string s in chapters) {
                if (s != null &&  s != "")
                    Console.WriteLine(s);
            }

        }


    }
}
