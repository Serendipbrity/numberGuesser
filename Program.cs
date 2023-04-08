// See https://aka.ms/new-console-template for more information

using System;

// Namespace
namespace numberGuesser 
{
    // Main Class
    class Program
    { 
        // Entry Point Method
        static void Main(string[]args)
        {
            GetAppInfo(); // run get app info function to get info

            GreetUser(); // ask for users name and greet

            while (true)
            {

                // create a new random object
                Random random = new Random();

                // generate random number from 1 to 10
                int correctNumber = random.Next(1, 10);

                // set guess
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        // keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // output success message
                PrintColorMessage(ConsoleColor.Green, "You are correct!");

                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void GetAppInfo()
        {
            // set app vars
            string appName = "numberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brittani";

            // change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //  write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //  reset text color
            Console.ResetColor();
        }

        // get and display app info
        static void GreetUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // tell user its wrong
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}