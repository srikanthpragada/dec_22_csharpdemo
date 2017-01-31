using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class MyDataContext : DataContext 
    {
        public MyDataContext() : 
            base(@"Data Source=(localdb)\v11.0;Initial Catalog=msdb;Integrated Security=True")
        {
        }
        public Table<Course> Courses
        {
            get
            {
                return GetTable<Course>();
            }
        }
    }
}
