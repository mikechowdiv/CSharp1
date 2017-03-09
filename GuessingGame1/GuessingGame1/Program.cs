using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            bool PlayAgain = false;
            do
            {
                Program stuff = new Program();
                stuff.PlayGame(name);

                Console.WriteLine("Do you want to play again?");
                string response = Console.ReadLine();
                switch (response.ToUpper())
                {
                    case "Y":
                    case "YES":
                        PlayAgain = true;
                        break;
                    default:
                        PlayAgain = false;
                        break;
                }
            } while (PlayAgain);
        }

        public void PlayGame(string name)
        {
            Console.WriteLine(name);
            Random rng = new Random();
            int numberToBeGuessed = rng.Next(1, 21);
            bool isValid = false;
            do
            {
                Console.WriteLine($"{name} enter a number btw 1 - 20 or Q to quit");
                string input = Console.ReadLine();
                int NumberGuessed;
                int.TryParse(input, out NumberGuessed);
                isValid = int.TryParse(input, out NumberGuessed);
                if (isValid)
                {
                    if (!(NumberGuessed <= 20 && NumberGuessed >= 1))
                    {
                        Console.WriteLine("the number needs to be btw 1 - 20");
                        isValid = false;
                    }
                    else
                    {
                        if (NumberGuessed == numberToBeGuessed)
                        {
                            Console.WriteLine("You Win");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry please try again");
                            isValid = false;
                        }
                    }
                }
                else
                {
                    if (input.ToUpper() == "Q")
                    {
                        return;
                    }
                    Console.WriteLine("what happened? ");
                }
            } while (!isValid);
        }
    }
}
