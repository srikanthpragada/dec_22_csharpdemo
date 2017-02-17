using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{
    class UpdateCourseDisconnected
    {
        public static void Main()
        {
            MyDBContext ctx = new MyDBContext();
            ctx.Database.Log = Console.WriteLine;
            Course course = ctx.Courses.Find("javaee");
            ctx.Dispose();

            ctx = new MyDBContext();   // Another Context 
            ctx.Database.Log = Console.WriteLine;
            course.Fee = course.Fee * 110 / 100;

            ctx.Courses.Attach(course);  // object is in Unchanged state 
            ctx.Entry(course).State = EntityState.Modified;
            ctx.SaveChanges();
            
            /*
            foreach (var c in ctx.Courses.ToList())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", c.Code, c.Title, c.Duration, c.Fee);
            }
            */

        }
    }
}
