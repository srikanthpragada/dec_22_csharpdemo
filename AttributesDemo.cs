using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class AttributesDemo
    {

        public static void Main()
        {
            Print();
        }

        [Obsolete ("Please use Prin2() instead")]
        public static void Print()
        {

        }
    }
}
