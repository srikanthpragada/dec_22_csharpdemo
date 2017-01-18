using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DelegateDemo
    {
        public delegate void PrintDelegate(string name);  // 1

        public static void Main()
        {
            PrintDelegate pd = new PrintDelegate(DisplayMessage);  // 2
            pd("Abc");

            PrintDelegate pd2 = DisplayMessage; // Method group conversion  // 3
            pd2("Hello!");

            // Anonymous method 
            PrintDelegate pd3 = delegate (string name)  // 4
            {
                Console.WriteLine("Hello, {0}", name);
            };

            pd3("Anonymous");

            PrintDelegate pd4 = name => Console.WriteLine(name);  // 5
            pd4("Lambda");

        }

        public static void DisplayMessage(String name)
        {
            Console.WriteLine("Printing..." + name);
        }
    }
}
