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
            Student s1 = new Student(1, "Bill");
            s1.Print();
            try
            {
                s1.Payment(1000);
                s1.Payment(5000);
            }
            catch (ExcessFeeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            s1.Print();

        }
    }
}
