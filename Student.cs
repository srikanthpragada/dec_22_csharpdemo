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
        public  int feepaid;

        // Constructor
        public Student(int admno, string name)
        {
            this.admno = admno;
            this.name = name; 
        }

        // Constructor
        public Student(int admno, string name, int feepaid)
        {
            this.admno = admno;
            this.name = name;
            this.feepaid = feepaid; 
        }

        // Methods 
        public void Print()
        {
            Console.WriteLine(this.admno);
            Console.WriteLine(this.name);
            Console.WriteLine(this.feepaid);
        }
        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public int FeePaid
        {
            get
            {
                return feepaid; 
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }
    }
}
