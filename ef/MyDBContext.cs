using System.Data.Entity;

namespace csharpdemo.ef
{
    class MyDBContext : DbContext
    {
        public MyDBContext() :
             base(@"Data Source=(localdb)\v11.0;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public DbSet<Course> Courses { get; set;}
    }
}
