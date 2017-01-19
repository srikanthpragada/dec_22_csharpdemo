using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Stack
    {
        private int[] data;
        private int top = 0; 

        public void Push(int n)
        { }
    }

    class StringStack
    {
        private string [] data;
        private int top = 0;

        public void Push(string n)
        { }
    }

    class  GenericStack<T>   // where T : IComparable<T>
    {
        private T[] data = new T[10];
        private int top = 0;

        public void clear()
        {
            top = 0; 
            for(int i = 0; i < 10; i ++)
            {
                data[i] = default(T);
            }
        }
        public void Push(T v)
        {

        }
    }
    class GenericsDemo
    {
        public static void Main()
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);

            GenericStack<String> names = new GenericStack<string>();
            names.Push("abc");

            GenericStack<Time> times = new GenericStack<Time>();
            times.Push( new Time { Hours = 10, Mins = 10, Secs = 10 });

            GenericStack<int> nums = new GenericStack<int>();
            


        }
    }
}
