using System;

namespace methodDemo
{

    class MethodDemo
    {
        public void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine("a inside method = {0}", a);
        }

        public void PassByReference(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] inside method = {0}", b[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
