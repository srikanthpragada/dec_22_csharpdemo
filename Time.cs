using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Time
    {
        public int Hours {get;set;}
        public int Mins { get; set; }
        public int Secs { get; set; }
        public int TotalSeconds
        {
            get
            {
                return Hours * 3600 + Mins * 60 + Secs;
            }
        }

        // Overload ==
        public static bool operator==(Time t1, Time t2)
        {
            return t1.TotalSeconds == t2.TotalSeconds;
        }

        public static bool operator!=(Time t1, Time t2)
        {
            return t1.TotalSeconds != t2.TotalSeconds;
        }

        public static bool operator>(Time t1, Time t2)
        {
            return t1.TotalSeconds > t2.TotalSeconds;
        }

        public static bool operator<(Time t1, Time t2)
        {
            return t1.TotalSeconds < t2.TotalSeconds;
        }

        public static explicit  operator int (Time t)
        {
            return t.TotalSeconds;
        }
        public static implicit operator Time (int t)
        {
            return new Time { Hours = t, Mins  = t, Secs = t };
        }
    }

    static class ExtMethods
    {
        public static void Print(this Time t)
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}", t.Hours, t.Mins, t.Secs);
        }
    }
    class TestTime
    {
        public static void Main()
        {
            Time t = 10; 

            Time t1 = new Time { Hours = 11, Mins = 20, Secs = 30 };
            Time t2 = new Time { Hours = 10, Mins = 20, Secs = 30 };

            #region Operator Overloading Demo             
            Console.WriteLine(t1 == t2);  // Time.operator==(t1,t2)
            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1 > t2);
            #endregion

            int n = (int) t1;  // Time to int 

            t1.Print();  //  ExtMethods.Print(t1)

        }
    }
}
