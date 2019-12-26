using System;

namespace swtichCaseExamples
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter your grade: ");
			string userGrade = Console.ReadLine();

            switch (userGrade)
            {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }
}
