using System;
using System.Collections.Generic;

class AssignmentPart4
{
    static void Main()
    {
        // Make a list of distinct strings.
        List<string> strTexts = new List<string> { "1string", "2string", "3string" };

        Console.WriteLine("Enter some text to search for:");

        // Accept the user's input
        string searchText = Console.ReadLine();

        bool matchFound = false;

        // Search for the text by iterating over the list.
        for (int i = 0; i < strTexts.Count; i++)
        {
            if (strTexts[i] == searchText)
            {
                Console.WriteLine($"Match found at index {i}");
                matchFound = true;
                break; // Exit the loop once a match is found
            }
        }

        // Check to see if a match was made.
        if (!matchFound)
        {
            Console.WriteLine("Your contribution is not in the given list");
        }

        // Before quitting, wait for the user to press a key.
        Console.ReadKey();
    }
}