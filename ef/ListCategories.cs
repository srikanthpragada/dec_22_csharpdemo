using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef 
{
    class ListCategories
    {
        public static void Main()
        {
            msdbEntities ctx = new msdbEntities();
            ctx.Database.Log = Console.WriteLine;
            // Linq to Entities 

            // Eager loading 
            foreach(var c in ctx.Categories.Include("Products").ToList())
            {
                Console.WriteLine("{0} - {1}", c.CatCode, c.CatDesc);
                // list products
                foreach (var p in c.Products)
                {
                    Console.WriteLine("       {0} - {1} - {2} ", p.ProdName,
                          p.Price, p.Qoh.HasValue ? p.Qoh.ToString() : "NULL");
                }
            }
            
        }
    }
}
