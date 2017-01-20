using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class SortPhones
    {
        public static void Main()
        {
            using (StreamReader sr = new StreamReader(@"f:\classroom\phones.txt"))
            {
                SortedDictionary<string, string> phones = new SortedDictionary<string, string>();
                String line;
                while (true)
                {
                    line = sr.ReadLine();
                    if (line == null)
                        break;

                    string[] parts = line.Split(':');

                    if (parts.Length != 2)
                        continue;

                    String name = parts[0];
                    string phone = parts[1];

                    if (phones.ContainsKey(name))
                        phones[name] = phones[name] + "," + phone;  
                    else
                        phones.Add(name,phone);
                }

                
                foreach (string name in phones.Keys)
                    Console.WriteLine("{0} - {1}", name, phones[name]);
            }




        }
    }
}
