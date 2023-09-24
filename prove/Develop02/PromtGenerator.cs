// Emplimentation of the promtGenerator class

class PromtGenerator
{
   // List<string> _prompts = new List<string>();

   public string[] _prompts = 

    {
        // The list of prompts that will be generated to the user for response.

        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "On a scale of 10 how many would I grade this day? with 10 being the highest score",
        "Is this the best day of your week so far?",
        "Have you achieved something great today?",
        "What is the your greatest achievement today?"
    };

    public PromtGenerator()
    {
        
    }

    public string GetRandomPrompt()
    {
        // The class responsible for generating the random promts.
        
        Random rand = new Random();
        string _prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(_prompt);
        return _prompt;  
    }
    
}