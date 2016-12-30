using System;
using System.IO;

namespace csharpdemo
{
    class DisplayFile
    {
        public static void Main()
        {
            Console.Write("Enter filename :");
            string filename = Console.ReadLine();

            try {
                StreamReader sr = new StreamReader(filename);

                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;

                    Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Sorry! File could not be opened!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Sorry! Could not process file!");
            }
        }
    }
}
