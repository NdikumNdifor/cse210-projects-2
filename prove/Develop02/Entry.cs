// entry class emplimentation

public class Entry
{
    /* 
      This class displays the date, prompts and users response
      in a defined string format .
    */
    public string _date;
    public string _prompt;
    public string _response;
    public  Entry(string aDate, string aPrompt, string aResponse)
    {
        _date = aDate;
        _prompt = aPrompt;
        _response = aResponse;  
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt} {_response}");
    }

    public string GetEntryAsCSV()
    {
        return string.Format("{0}-{1}-{2}", _date, _prompt, _response);
    }    
}