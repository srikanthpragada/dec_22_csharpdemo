using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class SortNames
    {
        public static void Main()
        {
            using (StreamReader sr = new StreamReader(@"f:\classroom\names.txt"))
            {
                List<string> names = new List<string>();
                String line;
                while (true)
                {
                    line = sr.ReadLine();
                    if (line == null)
                        break;
                    names.Add(line);
                }

                names.Sort();

                foreach (string name in names)
                    Console.WriteLine(name);
            }




        }
    }
}
