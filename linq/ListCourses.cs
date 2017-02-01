using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class ListCourses
    {
        public static void Main()
        {
            MyDataContext dc = new MyDataContext();
            var courses = from c in dc.Courses
                          where c.Fee > 3000
                          select new { Title = c.Title, Fee = c.Fee ,  NetFee = c.Fee * 0.90 };


            foreach(var c in courses)
            {
                Console.WriteLine("{0} - {1} - {2}", c.Title, c.Fee, c.NetFee);
            }

        }
    }
}
