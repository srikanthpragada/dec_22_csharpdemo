using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{
    class AddCourse
    {
        public static void Main()
        {
            MyDBContext ctx = new MyDBContext();

            Course course = new Course {Code = "bs3", Title = "BootStrap 3", Duration = 10, Fee = 1000 };
            ctx.Courses.Add(course);
            //ctx.SaveChanges();

            foreach (var c in ctx.Courses.OrderByDescending(crs => crs.Fee))
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", c.Code, c.Title, c.Duration, c.Fee);
            }

        }
    }
}
