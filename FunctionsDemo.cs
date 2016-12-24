using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class FunctionsDemo
    {
        static void Main()
        {
            int x = 10, y = 20;
            Swap(x, y);
            Console.WriteLine("{0} {1}", x, y);

            Interchange(ref x, ref y);
            Console.WriteLine("{0} {1}", x, y);

            // Demo of out modifier 
            int v;

            Zero(out v);
        }

        static void Zero(out int n)
        {
            n = 0; 
        }


        // pass by reference 
        static void Interchange(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
        // Pass by value
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
}
