using System;

/*
This application prompts the user to enter an integer between 1 and 100 inclusive and displays a result based on the integer 
range entered using conditional statements. The actions taken are: if the integer is odd and less than 60, it prints the number
and "Odd and less than 60"; if the integer is even and between 2 and 24 inclusive, it prints "Even and less than 25"; if the 
integer is even and between 26 and 60 inclusive, it prints "Even and between 26 and 60 inclusive"; if the integer is even and 
greater than 60, it prints the number and "Even and greater than 60"; if the integer is odd and greater than 60, it prints the 
number and "Odd and greater than 60". Additional requirements include completing the Lab Summary and ensuring no syntax errors. Extra challenges include allowing the program to continue running based on user input, asking for user information to personalize messages, and validating that the input is a positive integer between 1 and 100.
*/


namespace number_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to enter an integer between 1 and 100
            Console.WriteLine("Enter an integer between 1 and 100: ");
            //Create number variable to store user input and parse the input to an integer
            int userNumber = int.Parse(Console.ReadLine());

            //Check if the user input is odd and less than 60
            if (userNumber % 2 == 1 && userNumber < 60)
            {
                //Print the number and "Odd and less than 60 to the console app"
                Console.WriteLine(userNumber + " Odd and less than 60");
            }
            //Check if the user input is even and greater than 2 and less than 25
            else if ( userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
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

            //Make Visual Studio keep the consol window open
            Console.WriteLine("Press Enter");
            Console.ReadLine();

        }
    }
}
