using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the journal class with.

        Journal j1 = new Journal();
       
        List<string> menu = new List<string>()
        {
            // Menu of choices.

            "Please select one of the following choices",
            "1. Write",
            "2. Display",
            "3. Save",
            "4. Load",
            "5. Quit",
            "Chose what you want to do"  
        };

        // Looping along till the condition of chosing to "quit" by typing 5 is satisfied

        int task = -1;
        while(task != 5)
        {
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            string userInput = Console.ReadLine();
            task = int.Parse(userInput);
            
            if (task == 1)
            {
                j1.CreatJournalEntry();
            }

            else if(task == 2)
            {  
               j1.DisplayJournalEntry();
            }

            else if (task == 3)
            {
                j1.SaveToCSV();
            }

            else if (task == 4)
            {
                j1.LoadFromCSV();
            }

            else
            {
                Console.WriteLine("You are not entering a valad option");
            }
            
        }
    }
}