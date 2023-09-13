using System;

class Program
{
    static void Main(string[] args)
    {
        // The "Console.WriteLine()" is used to 
        // creat white space for cleaner readability
        Console.WriteLine();

        // Prompts the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        // Prompts the user for their Lastname
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();

        // Prints out a statement to the screen
        Console.WriteLine($"My name is {lastName}, {firstName} {lastName}.");
        Console.WriteLine();

    }
}