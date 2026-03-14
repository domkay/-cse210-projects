using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign = "";
        float percent;
        float lastDigit;
        Console.Write("Enter your grade percentage (0-100): ");
        string input = Console.ReadLine();
        percent = float.Parse(input);

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }
        
        if (percent >= 100)
        {
            sign = "";
        }

        Console.WriteLine($"\nYour grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep your head up! With a bit more practice, you'll nail it next time.");
        }
    }
}