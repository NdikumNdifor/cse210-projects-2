// Emplimentation of the journal class

public class Journal
{
    public List<Entry> _entries;
    public string fileExtension;

    public Journal()
    {
        _entries = new List<Entry>();
        fileExtension = ".csv";
    }
    public void CreatJournalEntry()
    {
        PromtGenerator haveAprompt = new PromtGenerator();
        string _prompt = haveAprompt.GetRandomPrompt();
        var todayDate = DateTime.Today;
        string _date = todayDate.ToString();
        Console.Write(">>");
        string _response = Console.ReadLine();
        Entry userEntry = new Entry(DateTime.Now.Date.ToString("MMM dd, yyyy"), _prompt, _response);
       /* userEntry._date = date;
        userEntry._prompt = prompt ;
        userEntry._response = userResponse; */
        _entries.Add(userEntry);
    }

    public void DisplayJournalEntry()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }  
    }

    public void SaveToCSV()
    {
        /* 
          Asks for the user to enter a file name without the extension,
          writes to the file and saves it with the enered file name 
        */
        Console.Write("Enter the file name(without the .csv extension at the end of your file name): ");
        string userInput = Console.ReadLine();
        string fileName = string.Concat(userInput,fileExtension);
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
                string csv = entry.GetEntryAsCSV();
                outputfile.WriteLine(csv);
            }   
        }

    }

    public void LoadFromCSV()
    {
        // Loads your saves in csv format
        
        string fileName = "journal.csv";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}