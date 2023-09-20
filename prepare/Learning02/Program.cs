using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Petroleum Engineer";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2010;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Allison Garden";

        myResume._container.Add(job1);
        myResume._container.Add(job2);
        
        
        Console.WriteLine();
        myResume.DisplayDetails();
        Console.WriteLine();
    
    }
}