using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Student
    {
        // Fields 
        private int admno;
        private string name;
        private int feepaid;

        // Constructor
        public Student(int no, string sname)
        {
            admno = no;
            name = sname; 
        }

        // Constructor
        public Student(int no, string sname, int amount)
        {
            admno = no;
            name = sname;
            feepaid = amount; 
        }

        // Methods 
        public void Print()
        {
            Console.WriteLine(admno);
            Console.WriteLine(name);
            Console.WriteLine(feepaid);
        }
        public void Payment(int amount)
        {
            feepaid += amount;
        }
    }
}
