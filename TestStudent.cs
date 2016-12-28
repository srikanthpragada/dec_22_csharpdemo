using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class TestStudent
    {
        public static void Main()
        {
            Student s1 = new Student(1,"Bill");
            s1.Print();

            Student.CourseFee = 6000;  // set method

            Console.WriteLine(Student.CourseFee);  // get method 

            






        }
    }
}
