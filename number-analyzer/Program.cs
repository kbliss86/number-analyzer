using System;

/*
This application prompts the user to enter an integer between 1 and 100 inclusive and displays a result based on the integer 
range entered using conditional statements. The actions taken are: if the integer is odd and less than 60, it prints the number
and "Odd and less than 60"; if the integer is even and between 2 and 24 inclusive, it prints "Even and less than 25"; if the 
integer is even and between 26 and 60 inclusive, it prints "Even and between 26 and 60 inclusive"; if the integer is even and 
greater than 60, it prints the number and "Even and greater than 60"; if the integer is odd and greater than 60, it prints the 
number and "Odd and greater than 60". Additional requirements include completing the Lab Summary and ensuring no syntax errors.
*/

/*
Extra Credit: To earn up to 2 extra points, you can implement the following enhancements: 1) Set up the
program to continue running with a prompt at the end asking if the user wants to stop, utilizing loops 
to achieve this functionality. 2) Prompt for the user's name at the beginning of the application and 
use it to personalize the messages throughout the application. 3) Add validation to ensure the user 
enters a positive integer between 1 and 100, improving the robustness and user-friendliness of the 
application.
*/


namespace number_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set userChoice variable to "Y" to start the loop - EC enhancement
            string userChoice = "Y";// in order to use a while loop the variable it evaluates must be declared outside of the loop first

            //Prompt user to enter their name - EC enhancement
            Console.WriteLine("Please Enter you first name"); //Always say please!
            string userName = Console.ReadLine(); //Store user input in userName variable

            //Start of For Loop - EC enhancement
            //Utilize a while loop to keep the program running untul the variable userChoice is not equal to "Y"
            //While Loop is a "loop" that differs from a for each loop in that it will continue to run until the condition is false instead of waiting on iterations to reach a certain length - userChoise variable is established at the begining of the program to start the loop and can be changed with the final question
            while (userChoice == "Y")
            {
                int userNumber = 0; //Declare userNumber variable outside of the loop to avoid re-declaring it in the loop -- EC enhancement
                bool correctInput = false; //Declare correctInput variable to check if the user input is correct - EC enhancement
                //while loop to make sure the user inputs a number between 1 and 100 - EC enhancement
                while (!correctInput)
                {
                    //Prompt user to enter an integer between 1 and 100
                    Console.WriteLine($"{userName}, Please enter an integer between 1 and 100: "); //Personalized message using the user's name - EC enhancement -- Interpolation is used to insert the user's name into the string
                    //Create number variable to store user input and parse the input to an integer
                    userNumber = int.Parse(Console.ReadLine());
                    if (userNumber >= 1 && userNumber <= 100)
                    {
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please restart the application and try again and this time FOLLOW THE RULES");
                    }
                }
                //Check if the user input is odd and less than 60
                if (userNumber % 2 == 1 && userNumber < 60)
                {
                    //Print the number and "Odd and less than 60 to the console app"
                    Console.WriteLine(userNumber + " Odd and less than 60");
                }
                //Check if the user input is even and greater than 2 and less than 25
                else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
                {
                    //Print "Even and less than 25" to the console app
                    Console.WriteLine("Even and less than 25");
                }
                //Check if the user input is even and between 26 and 60
                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {
                    //Print "Even and between 26 and 60 inclusive" to the console app
                    Console.WriteLine("Even and between 26 and 60 inclusive");
                }
                else if (userNumber % 2 == 0 && userNumber > 60)
                {
                    //Print the number and "Even and greater than 60" to the console app
                    Console.WriteLine(userNumber + " Even and greater than 60");
                }
                else if (userNumber % 2 == 1 && userNumber > 60)
                {
                    //Print the number and "Odd and greater than 60" to the console app
                    Console.WriteLine(userNumber + " Odd and greater than 60");
                }

                //Prompt user to enter "Y" to continue or "N" to stop the program - EC enhancement
                Console.WriteLine($"{userName}, Would you like to analyze another number? (Y/N)");//Personalized message using the user's name - EC enhancement -- Interpolation is used to insert the user's name into the string
                userChoice = Console.ReadLine().ToUpper(); //Store user input in userChoice variable and convert to uppercase
                while (userChoice != "Y" && userChoice != "N")//Utilize another while loop to make sure users gives a correct response so the app does not crash!
                {
                    Console.WriteLine("Invalid input. Please enter Y or N: "); //Always say please!
                    userChoice = Console.ReadLine().ToUpper(); //Store user input in userChoice variable and convert to uppercase
                }
            }
            //Final Message to the user
            Console.WriteLine("Game Over! Press Enter Twice to exit the program.");
            //Make Visual Studio keep the consol window open
            Console.ReadLine();

        }
    }
}