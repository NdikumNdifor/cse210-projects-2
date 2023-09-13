using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random nuber between 1-100
        Random randomGenerator = new Random();
        int theNumber = randomGenerator.Next(1, 100);

        // Initializes the guess number to -1
        int guess = -1;

        // Initializing the number of counts to zero
        int guessCount = 0;

        // Keeps on looping while the guess is not equale to the set value(the magic number)
        // and guide the user on his next choice
        Console.WriteLine();
        while (guess != theNumber)
            {
                Console.Write("What is your guess number? ");
                string myMagicNumber = Console.ReadLine();
                guess = int.Parse(myMagicNumber);

                Console.WriteLine();
                // Keeping track of the number of counts
                guessCount += 1;

                if (guess == theNumber)
                {
                    Console.WriteLine("You have guessed it correctly");
                    Console.WriteLine($"You guessed after {guessCount} counts.");
                }
                else if (guess > theNumber)
                {
                    Console.WriteLine("You guessed High, guess lower"); 
                }
                else if (guess < theNumber)
                {
                    Console.WriteLine("You guessed Low, guess higher");
                }
                Console.WriteLine();
            }
    }
}