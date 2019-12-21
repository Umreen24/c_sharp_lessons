using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            int[] numbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //foreach loop
            char[] message = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char i in message)
            {
                Console.Write(i);
            }

            //while loop
            int counter = 5;
            while (counter > 0)
            {
                Console.WriteLine("Counter = {0}", counter);
                counter -= 1;
            }
        }
    }
}
