using System;

class Program
{
    static void Main(string[] args)
    {
        // This program introduces us to the concept of list in in C# 

        List<int> numbers = new List<int>();

        int number = -1;
        
        while (number != 0)
        {
            Console.Write("Please enter a number: ");
            string enteredNumber = Console.ReadLine();
            number = int.Parse(enteredNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }      
        }

        // Computing the sum of all the elements in the list.
        int sum = 0;
        foreach (int element in numbers)
        {
            sum += element;
        }
        Console.WriteLine();
        Console.WriteLine($"The sum is: {sum}");

        // Calculating the average number.
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average number is: {average}");

        // Looking for the maximum number entered in the list
        int max = -100000;
        foreach (int numb in numbers)
        {
            if (numb > max)
            {
                max = numb;
            }
        }
        Console.WriteLine($"The maximum number in the list is: {max}");

        // Looking for the minimum number in the list
        int min = 9999999;
        foreach (int smallestNumb in numbers)
        {
            if (smallestNumb < min)
            {
                min = smallestNumb;
            }
        }
        Console.WriteLine($"The minimum number in the list is: {min}");
        Console.WriteLine();

    }
}