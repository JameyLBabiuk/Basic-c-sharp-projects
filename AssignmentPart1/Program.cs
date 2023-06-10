using System;

class AssignmentPart1
{
    static void Main()
    {
        // Creating an array of strings
        string[] strTexts = new string[] { "1string", "2string", "3string"};

        Console.WriteLine("Input your text:");

        // View user input
        string userInput = Console.ReadLine();

        // Code to loop through & update every string in the array
        for (int i = 0; i < strTexts.Length; i++)
        {
            strTexts[i] += userInput;
        }

        // Print each string by iterating through the updated array.
        foreach (string txt in strTexts)
        {
            Console.WriteLine(txt);
        }

        // Before quitting, wait for the user to touch a key.
        Console.ReadKey();
    }
}