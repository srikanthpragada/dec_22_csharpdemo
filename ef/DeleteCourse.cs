using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{
    class DeleteCourse
    {
        public static void Main()
        {
            MyDBContext ctx = new MyDBContext();
            ctx.Database.Log = Console.WriteLine;

            Course course = ctx.Courses.Find("bs3");
            if(course == null)
            {
                Console.WriteLine("Sorry! Course Not Found!");
                return; 
            }

            ctx.Courses.Remove(course);
            ctx.SaveChanges();
            

            foreach (var c in ctx.Courses.ToList())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", c.Code, c.Title, c.Duration, c.Fee);
            }

        }
    }
}
