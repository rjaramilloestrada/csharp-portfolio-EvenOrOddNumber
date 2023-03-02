using System;
using System.Runtime.ConstrainedExecution;

namespace EvenorOddNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            int userNum;

            if (int.TryParse(userInput, out userNum))
            {
                if (userNum%2 == 0)
                
                {
                    Console.WriteLine("You entered: " + userNum + " and it is an even number");
                }

                else
                {
                    Console.WriteLine("You entered: " + userNum + " and it an odd number");
                }
            }

            else 
            {
                Console.WriteLine("Incorret input. Please enter a number.");
            }

            Console.Read();
        }
    }
}
