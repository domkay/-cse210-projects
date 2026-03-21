using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2020;
        
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Senior Softare developer";
        job2._startYear = 2020;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Madji";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // job1.Display();
        // job2.Display();
        // Console.WriteLine("Hello World! This is the Resumes Project.");
        resume1.Display();
    }
}