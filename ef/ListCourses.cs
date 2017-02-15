using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef 
{
    class ListCourses
    {
        public static void Main()
        {
            MyDBContext ctx = new MyDBContext();
            // Linq to Entities 
            var courses = from c in ctx.Courses
                          where c.Fee > 3000
                          orderby c.Fee descending
                          select c;
                          

            // var courses = ctx.Courses;


            foreach (var c in courses)
            {
                Console.WriteLine("{0} - {1} - {2}", c.Title, c.Duration, c.Fee);
            }

        }
    }
}
