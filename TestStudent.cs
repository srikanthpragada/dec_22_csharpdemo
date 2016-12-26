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
            Student s; // object reference 

            s = new Student(1,"Bill");
            s.Payment(1000);
            s.Payment(4500);
            s.Print();

        }
    }
}
