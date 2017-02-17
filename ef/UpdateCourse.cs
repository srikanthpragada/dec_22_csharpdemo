using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{
    class UpdateCourse
    {
        public static void Main()
        {
            MyDBContext ctx = new MyDBContext();
            ctx.Database.Log = Console.WriteLine;


            Course course = ctx.Courses.Find("javaee");
            if(course == null)
            {
                Console.WriteLine("Sorry! Course Not Found!");
                return; 
            }

            course.Fee = course.Fee * 110 / 100;     
            ctx.SaveChanges();
            

            foreach (var c in ctx.Courses.ToList())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", c.Code, c.Title, c.Duration, c.Fee);
            }

        }
    }
}
