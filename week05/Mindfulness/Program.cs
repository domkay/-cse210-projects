/*
 * * EXCEEDING REQUIREMENTS:
 * This program exceeds the core requirements by implementing a session tracking system. 
 * I added a 'static' member variable to the base Activity class to track the total number 
 * of activities performed across all types (Breathing, Reflection, Listing). When the 
 * user exits the program, it displays a summary message showing the total session count 
 * for the day.
 */

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                
                // Accessing the static variable via the Class name
                if (Activity.SessionCount > 0)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"TOTAL SESSIONS COMPLETED: {Activity.SessionCount}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Keep up the great work on your mental well-being!");
                }
                else
                {
                    Console.WriteLine("We hope to see you back soon for your first session!");
                }
                //Wait 4 seconds so they can see the final report
                Thread.Sleep(4000); 
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please select 1-4.");
                Thread.Sleep(1500);
            }
        }
    }
}