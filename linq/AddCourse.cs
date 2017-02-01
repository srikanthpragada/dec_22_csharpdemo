using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class AddCourse
    {
        public static void Main()
        {
            MyDataContext dc = new MyDataContext();
            dc.Log = Console.Out; 

            Course c = new Course { Code = "javaee", Title = "Java EE", Duration = 40, Fee = 4000 };
            dc.Courses.InsertOnSubmit(c);
            dc.SubmitChanges();


        }
    }
}
