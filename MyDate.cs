using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class InvalidDate : Exception
    {
        public InvalidDate(string msg) : base(msg)
        { }
    }
    class MyDate
    {

        public int GetMonthDays(int month, int year)
        {
            switch (month)
            {
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        return 29;
                    else
                        return 28;
                case 4:
                case 6:
                case 9:
                case 11: return 30;
                default: return 31;
            }

        }

        public MyDate(int d, int m, int y)
        {
            if (y < 1000 || y > 9999)
                throw new InvalidDate("Year is invalid!");

            if (m < 1 || m > 12)
                throw new InvalidDate("Month is invalid!");

            int nodays = GetMonthDays(m, y);

            if ( d < 1 || d > nodays)
                throw new InvalidDate("Day is invalid!");

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
            MyDate d = new MyDate(37,12,2016);
            





        }
    }
}
