using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ListEmails
    {
        public static void Main()
        {
            Console.Write("Enter filename :");
            string filename = Console.ReadLine();

            StreamReader sr = new StreamReader(filename);
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;
                string[] emails = line.Split(',', ';', ' ');

                foreach (string email in emails)
                    Console.WriteLine(email);
            }

            sr.Close(); 
        }
    }
}
