using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class MonthDays
    {
        public static void Main()
        {
            Console.WriteLine("No. of days in May 2000 is : {0} ", GetMonthDays(2, 2000));
        }

        public static int GetMonthDays(int month, int year)
        {
            switch(month)
            {
                case 2 :
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
    }
}
