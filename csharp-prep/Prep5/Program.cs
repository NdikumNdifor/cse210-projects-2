using System;

class Program
{
    static void Main(string[] args)
    {
      // This program is to practice writing reusable functions in C#


        // A call to written functions at the main.
        Console.WriteLine();
        DisplayWelcome();
        Console.WriteLine();
        string EnteredName = PromtUserName();
        int EnteredNumber = PromtUserNumber();
        Console.WriteLine();
        int computeSquare = SquareNumber(EnteredNumber);
        DisplayResult(EnteredName, computeSquare);
        Console.WriteLine();
        
        static void DisplayWelcome()
        {
            // A function with that displays a welcome message and takes no parameter.
            Console.WriteLine("Welcome to the programm");
        }

        static string PromtUserName()
        {
            // Ask for the user's name and returns a string.
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromtUserNumber()
        {
            // Ask for the user's favorite number and returns an interger.
            Console.Write("Eenter your favorite number: ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        static int SquareNumber(int number)
        {
            // Takes an interger as parameter,computes the squre of that interger and returns it.
            int square = number * number;
            return square;
        }

        // Takes a string and interger as parameters and display a result.
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Your name is {name} and the square of your number is {square} ");
        }  
    }
}