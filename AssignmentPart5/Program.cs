using System;
using System.Collections.Generic;

class AssignmentPart5
{
    static void Main()
    {
        // Create a list of strings with at least two identical strings
        List<string> strTexts = new List<string> { "1string", "2string", "3string"};

        Console.WriteLine("Enter some text to search for:");

        // Read the user's input
        string searchText = Console.ReadLine();

        bool matchFound = false;

        // Search for the text by iterating over the list.
        for (int i = 0; i < strTexts.Count; i++)
        {
            if (strTexts[i] == searchText)
            {
                Console.WriteLine($"Match found at index {i}");
                matchFound = true;
            }
        }

        // Check to see if a match was made.
        if (!matchFound)
        {
            Console.WriteLine("Your input is not on the list.");
        }

        // Before quitting, wait for the user to touch a key.
        Console.ReadKey();
    }
}