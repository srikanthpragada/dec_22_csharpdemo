using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Factors
    {
        static void Main(string [] args)
        {
            if( args.Length == 0)
            {
                Console.WriteLine("Missing number on command line! Quitting...");
                return; 
            }

            int num = Int32.Parse(args[0]);  // convert string to int

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
