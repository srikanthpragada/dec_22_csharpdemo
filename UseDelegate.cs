using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class UseDelegate
    {
        public static void Main()
        {
            int[] a = {13, 20, 22, 15, 23, 40 };

            int [] sa = Array.FindAll(a, new Predicate<int>(IsEven));

            sa = Array.FindAll(a, IsEven);

            sa = Array.FindAll(a,
                   delegate(int n) 
                   {
                      return n % 2 == 1;
                   } 
                 );

            sa = Array.FindAll(a, n => n % 5 == 0 );

            foreach (int n in sa)
                Console.WriteLine(n);
        }
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
