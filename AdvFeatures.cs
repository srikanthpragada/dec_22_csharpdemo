using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class AdvFeatures
    {
        public static void Main()
        {
            var v = 10;
            var n = "Abc";
            var d = DateTime.Now;
            var num = new int [] { 10, 20, 30 };

            var person = new { Name = "Srikanth", Mobile = "9059057000" };
            Console.WriteLine(person.Name);

            dynamic p;

            p = "Abc";
            Console.WriteLine(p.ToUpper());
            p = new Time();
            Console.WriteLine(p.Hours);








        }
    }
}
