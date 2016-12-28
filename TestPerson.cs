using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class TestPerson
    {
        static void Main()
        {
            // upcasting 
            Person p = new Employee("Steve", "steve@apple.com", "Apple", "Programmer");
            p.Print();  // runtime polymorphism - late binding 

            p = new OSEmployee("Elon", "elon@gmail.com", "Tesla", "Designer", "US");
            p.Print();  // runtime polymorphism - late binding 

        }
    }
}
