// implementation of the resume class


public class Resume
{
    public string _name;
    public List<Job> _container = new List<Job>();
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job content in _container)
        {
           content.Display(); 
        }
    }

}