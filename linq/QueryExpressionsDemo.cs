using System;
using System.Linq;

namespace linq
{
    class QueryExpressionsDemo
    {
        static void Main()
        {
            Book[] books = Book.GetBooks();

            var books1 = from b in books
                         where b.Price > 500
                         select b;

            var sbooks =  from b in books
                          where b.Price > 500
                          orderby b.Price 
                          select new { Title = b.Title, 
                                       SellingPrice = b.Price * 1.1 };

            //foreach (var b in sbooks)
            //    Console.WriteLine("{0},{1}", b.Title, b.SellingPrice);

            // get books with max price 
            var maxprice = books.Max( b => b.Price );
            var maxbook = (from b in books
                           where b.Price == maxprice
                           select b).Single();

            var top3prices = (from b in books
                              orderby b.Price descending
                              select b).Take(3);

            foreach (var b in top3prices)
               Console.WriteLine("{0},{1}", b.Title, b.Price);

        }
    }
}
