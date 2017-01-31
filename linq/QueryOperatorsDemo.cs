using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class QueryOperatorsDemo
    {
        static void Main()
        {

            Book[] books = Book.GetBooks();

            // Non-linq way
            List<Book> selbooks = new List<Book>();
            foreach(Book b in books)
            { if (b.Price > 500)
                    selbooks.Add(b);
            }

            var top3books = books.Take(3);

            var books2to4 = books.Skip(1).Take(3).OrderBy(b => b.Price);

            //foreach (var b in books2to4)
            //    Console.WriteLine("{0},{1}", b.Title, b.Price);


            var sb = books.Where(b => b.Price > 500)
                          .OrderByDescending(b => b.Price);

            var max = books.Max(b => b.Price);

            var hpb = books.Where(b => b.Price == max).First();

            //foreach (var b in sb)
            //    Console.WriteLine("{0},{1}", b.Title, b.Price );

            var sb2 = books.Where(b => b.Price > 500)
                           .Select(b => new { Title = b.Title.ToUpper(),
                                              NetPrice = b.Price * 0.80 });


            foreach (var b in sb2)
                Console.WriteLine("{0},{1}", b.Title, b.NetPrice);

        }

    }
}
