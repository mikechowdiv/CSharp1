using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Before starting the game, ask for the player’s name. Then use their name in all of the messages and notifications throughout the game.
If the player doesn’t enter a number within the valid range (i.e. 1-20), give them a message that indicates the error and ask them to try again.
Allow the player to quit anytime throughout game play by entering Q.
Keep track of how many attempts it takes for the player to guess the right number and let them know when the game is over.
If the player guesses the correct answer on the first try, give them a special victory message.
Change the font colors in the game for different messages:
All standard instructions in the game should be presented in white font
All error messages should be presented in red font
All Victory messages should be presented in green font
You can do this using the Console.ForeColor property. Research this online.
Allow the user to select different modes at the beginning of the game. Each mode should change the range of numbers that are used for guessing:
Easy mode 1-5
Normal mode 1-20
Hard mode 1-50
             */

            int theAnswer = 1;
            int playerGuess;
            string playerName;
            string playerInput;
            bool isNumberGuessed = false;
            int playerAttempts = 0;
            string gameMode = "4";
            int startingPoint = 1;
            int endingPoint = 5;

            Random r = new Random();

            //general welcome message
            Console.WriteLine("Welcome to the Guessing Game");
            Console.WriteLine("Press any key to continue or Q to quit");

            //get Player name
            Console.WriteLine("Enter your name");
            playerName = Console.ReadLine();
            if((playerName == "Q") || (playerName == "q")) Environment.Exit(0);

            //let user select game mode
            while ((gameMode != "1") && (gameMode != "2") && (gameMode != "3"))
            {
                Console.WriteLine("Select Game Difficulty");
                Console.WriteLine("Select 1 for Easy (1-5)");
                Console.WriteLine("Select 2 for Normal (1-20)");
                Console.WriteLine("Select 1 for Hard (1-50)");
                gameMode = Console.ReadLine();
                if((gameMode == "Q") || (gameMode == "q")) Environment.Exit(0);

                switch (gameMode)
                {
                    case "2":
                        startingPoint = 1;
                        endingPoint = 20;
                        theAnswer = r.Next(startingPoint, endingPoint + 1);
                        break;
                    case "3":
                        startingPoint = 1;
                        endingPoint = 50;
                        theAnswer = r.Next(startingPoint, endingPoint + 1);
                        break;
                    default:
                        startingPoint = 1;
                        endingPoint = 5;
                        theAnswer = r.Next(startingPoint, endingPoint + 1);
                        break;
                }
            }

            do
            {
                //get player guess
                Console.WriteLine($"{playerName}, enter your guess ({startingPoint}-{endingPoint}): ");
                playerInput = Console.ReadLine();
                if ((playerInput == "Q") || (playerInput == "q")) Environment.Exit(0);

                //convert string to number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    if ((playerGuess < startingPoint) || (playerGuess > endingPoint))
                    {
                        Console.WriteLine(
                            $"{playerName}, the number is not between {startingPoint}-{endingPoint}. Try Again ");
                        Console.WriteLine($"{playerName}, I am still counting that towards your attempts");
                        playerAttempts++;
                    }
                    else
                    {
                        if (playerGuess == theAnswer)
                        {
                            playerAttempts += 1;
                            if (playerAttempts == 1)
                            {
                                Console.WriteLine($"{playerName}, Good Job Win at 1st try");
                            }
                            else
                            {
                                Console.WriteLine($"{playerName}, you win!");
                                Console.WriteLine($"{playerName}, it took you {playerAttempts} times to win");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, wrong input!");
                            playerAttempts += 1;
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine($"{playerName}, too high!");
                            }
                            else
                            {
                                Console.WriteLine($"{playerName}, too low");
                            }
                        }
                    }
                }
            } while (!isNumberGuessed);
        }
    }
}
