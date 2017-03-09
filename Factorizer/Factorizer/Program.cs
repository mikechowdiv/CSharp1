using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
  The C# project you are provided with has some pre-built methods that you will need to implement:

The GetNumberFromUser() method should prompt the user for an integer. The prompt should repeat until the user enters a valid integer. See the string input lesson for examples of how to do this.
The PrintFactors() method should print the factors of the given number.
The IsPerfectNumber() method should print a message regarding whether the number is perfect.
The IsPrimeNumber() method should print a message regarding whether the number is prime.
             */

            int num = GetNumFromUser();
            Calculator.PrintFactor(num);
           Calculator.IsPerfectNumber(num);
            Calculator.isPrimeNumber(num);

            Console.WriteLine("Press any key to quit....");
            Console.ReadKey();
        }

        static int GetNumFromUser()
        {
            string input;
            int output;
            do
            {
                Console.WriteLine("Enter an integer: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out output));
            return output;
        }
    }

    class Calculator
    {
        //get a number, print the factors per the specification
        public static void PrintFactor(int num)
        {
            string result = $"The factors of {num} are: ";
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    result += i + " ";
                }
                Console.WriteLine(result);
            }
        }

        //Print perfect number
        public static void IsPerfectNumber(int num)
        {
            int total = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    total += i;
                }
            }
            if (total == num)
            {
                Console.WriteLine($"{num} is a prefect number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prefect number.");
            }
        }

        //given a number check whether prime or not
        public static void isPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is a prime number");
        }
    }
}
