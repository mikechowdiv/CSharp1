using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string userName;
            string userGuess;
            int answer = rng.Next(1, 21);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine(userName + " press Q to quit anytime");

            do
            {
                Console.WriteLine(userName + " guess a number from 1-20");
                userGuess = Console.ReadLine();
                if (userGuess == "q")
                {
                    Console.WriteLine(userName + "thanks for playing");
                    break;
                }

                int.TryParse(userGuess, out guess);

                if (guess > 20)
                {
                    Console.WriteLine(userName + " that number is too large");
                }
                if (guess < 1)
                {
                    Console.WriteLine(userName + " that number is too small");
                }
                attempts++;

            } while (answer != guess);

            if (answer == guess && attempts == 1)
            {
                Console.WriteLine(userName + " good job. correct at 1st try");
            }
            else if (answer == guess)
            {
                Console.WriteLine(userName + " you win");
                Console.WriteLine("it took you " + attempts + " attempts to guess the correct number");
            }

            Console.ReadLine();
        }
    }
}
