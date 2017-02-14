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
            MyDBContext dc = new MyDBContext();
            // Linq to Entities 
            var courses = from c in dc.Courses
                          select c; 
                          


            foreach(var c in courses)
            {
                Console.WriteLine("{0} - {1} - {2}", c.Title, c.Duration, c.Fee);
            }

        }
    }
}
