using System;
using System.Collections.Generic;

class AssignmentPart6
{
    static void Main()
    {
        // Create a list of strings with at least two identical strings
        List<string> strTexts = new List<string> { "A", "B", "C", "D", "C" };

        // Create a HashSet to keep track of seen strings
        HashSet<string> seenStrings = new HashSet<string>();

        // Loop through each item in the list using foreach
        foreach (string txt in strTexts)
        {
            // Check if the string has already appeared in the list
            if (seenStrings.Contains(txt))
            {
                Console.WriteLine($"{txt} - this is a duplicate item.");
            }
            else
            {
                Console.WriteLine($"{txt} - this thing is special.");

                // The string is added to the HashSet.
                seenStrings.Add(txt);
            }
        }

        // Before quitting, wait for the user to touch a key.
        Console.ReadKey();
    }
}
