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
            // Linq to Entities 
            var cats = from c in ctx.Categories
                       select c; 

            foreach(var c in cats)
            {
                Console.WriteLine("{0} - {1}", c.CatCode, c.CatDesc);
                // list products

                foreach(var p in c.Products)
                {
                    Console.WriteLine("       {0} - {1} - {2} ", p.ProdName,
                          p.Price, p.Qoh.HasValue ? p.Qoh.ToString() : "NULL");
                }
            }

        }
    }
}
