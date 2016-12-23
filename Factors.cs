using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Factors
    {
        static void Main()
        {
            Console.Write("Enter a number :");
            string input = Console.ReadLine();  // read a line from keyboard

            int num = Int32.Parse(input);  // convert string to int

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
