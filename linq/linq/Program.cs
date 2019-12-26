using System;
using System.Linq;

namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var evenNum =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int i in evenNum)
            {
                Console.WriteLine("{0} is an even number", i);
            }

        }


    }

}
