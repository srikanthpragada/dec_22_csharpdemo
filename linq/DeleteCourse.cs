using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class DeleteCourse
    {
        public static void Main()
        {
            MyDataContext dc = new MyDataContext();
            dc.Log = Console.Out;

            var course = (from c in dc.Courses
                          where c.Code == "aj"
                          select c).SingleOrDefault();

            if (course == null)
                Console.WriteLine("Sorry! Course Not Found!");
            else
            {
                dc.Courses.DeleteOnSubmit(course);
                dc.SubmitChanges();
                Console.WriteLine("Deleted Course Successfully!");
            }

        }
    }
}
