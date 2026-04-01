using System;

// Exceeding Requirements:
// 1. Optimized the HideRandomWords method to only select from words that are not 
//    already hidden (the Stretch Challenge). This prevents the program from 
//    stalling as the scripture becomes mostly hidden.
// 2. Added logic to handle "remaining" words—if the user asks to hide 3 words 
//    but only 1 is visible, the program hides the last word and ends gracefully.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}