using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ThreadDemo
    {
        public static void Main()
        {
            Thread t = new Thread(Print);
            t.Start();

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Main " + i);

            Thread t2 = new Thread(delegate()
                {
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine("Child2 " + i);
                }
                );
            t2.Start();
        }

        public static void Print()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Child " + i);
        }
    }
}
