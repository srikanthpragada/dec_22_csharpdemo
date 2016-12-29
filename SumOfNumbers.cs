using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class SumOfNumbers
    {
        static void Main()
        {
            string snum;
            int sum = 0, num;

            while(true)
            {
                snum = Console.ReadLine();
                if (snum == "0")
                    break;

                try {
                    num = Int32.Parse(snum);
                    sum += num;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }

            Console.WriteLine(sum);
        }
    }
}
