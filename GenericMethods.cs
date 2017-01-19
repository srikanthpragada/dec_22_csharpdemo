using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class GenericMethods
    {
        public static void Print<T>(T [] a)
        {
            foreach (T v in a)
                Console.WriteLine(v);
        }

        public static void Main()
        {
            int[] a = { 10, 20, 30 };
            string[] names = { "Bill", "Larry", "Steve" };
            Print(a);
            Print(names);
        }
    }
}
