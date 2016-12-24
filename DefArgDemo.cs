using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DefArgDemo
    {
        static void Main()
        {
            Print('*',5);
            Console.WriteLine();
            Print('-');
            Console.WriteLine();
            Print();
            Console.WriteLine();
            Print('.',5);
        }
        static void Print(char ch = '.', int len = 10)
        {
            for (int i = 1; i <= len; i++)
            {
                Console.Write(ch);
            }
        }
    }
}
