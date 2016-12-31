using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class SearchString
    {
        public static void Main()
        {
            string filename = "f:\\classroom\\emails.txt";

            Console.Write("Enter string :");
            string search = Console.ReadLine();

            int lineno = 1;
            StreamReader sr = new StreamReader(filename);
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                if (line.Contains(search))
                    Console.WriteLine("{0}:{1}",lineno, line);

                lineno++;
            }

            sr.Close(); 
        }
    }
}
