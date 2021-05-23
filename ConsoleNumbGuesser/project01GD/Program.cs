using System;

namespace project01GD
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); //Ask for username and greet

            while (true) { 

            //Create a new random object
            Random random = new Random();

            int correct_number = random.Next(1, 10);  

            //Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10!");

            //While guess is not correct
            while (guess != correct_number){


                //Get users input 
                string input = Console.ReadLine();


                //Make sure that users are not inputing strings
                if (!int.TryParse(input, out guess)){
 
                    //Keep going
                    continue;
                }

            //Cast to int and put in guess
            guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess != correct_number){

                //Set error message
                 PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again!");

                    }

                }

                //Set correct message
                PrintColorMessage(ConsoleColor.Yellow, "Good job! This is a correct number!");

                //Ask user to play again 
                Console.WriteLine("Wanna play again? [Y or N]");

                //Get answer
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
        //Get and display app info
        static void GetAppInfo()
        {
            //Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andregiso";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }
        //Ask username and greet
        static void GreetUser()
        {
            //Ask useres name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change Text Color
            Console.ForegroundColor = color;

            //Tell user this is not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}


