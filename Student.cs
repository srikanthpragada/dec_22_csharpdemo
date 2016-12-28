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
        // Class variable
        private static int courseFee = 5500;

        public static int CourseFee
        {
            get
            {
                return courseFee;
            }
            set
            {
                courseFee = value; 
            }
        }

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
            if (feepaid + amount > courseFee)
                Console.WriteLine("Sorry! Excess fee being paid");
            else
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
