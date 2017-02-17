using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{
    class AddTopic
    {
        public static void Main()
        {
            MyDBContext ctx = new MyDBContext();

            Course course = ctx.Courses.Find("javase");
            Topic topic = new Topic { Course = course, Title = "Networking" };
            ctx.Topics.Add(topic);
            ctx.SaveChanges();
            

        }
    }
}
