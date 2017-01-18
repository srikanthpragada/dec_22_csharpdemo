﻿using System;
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

    class TestTime
    {
        public static void Main()
        {
            Time t = 10; 

            Time t1 = new Time { Hours = 11, Mins = 20, Secs = 30 };
            Time t2 = new Time { Hours = 10, Mins = 20, Secs = 30 };
            
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1 > t2);

            int n = (int) t1;  // Time to int 
        }
    }
}
