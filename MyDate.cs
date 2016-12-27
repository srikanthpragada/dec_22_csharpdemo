using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class MyDate
    {
        public MyDate(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y; 
        }
        public MyDate()
        {

        }
        public int Day { get; set;  }
        public int Month { get; set; }
        public int Year { get; set; }
    }

    class TestDate
    {
        public static void Main()
        {
            MyDate d = new MyDate(27,12,2016);
            Console.WriteLine("{0}-{1}-{2}", d.Day, d.Month, d.Year);

            // Object initializer 
            MyDate d2 = new MyDate { Day = 1, Month = 1, Year = 2017 };
            Console.WriteLine("{0}-{1}-{2}", d2.Day, d2.Month, d2.Year);





        }
    }
}
