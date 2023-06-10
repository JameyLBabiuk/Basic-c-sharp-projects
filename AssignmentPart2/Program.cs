using System;

class AssignmentPart2
{
    static void Main()
    {
        // Create a string array.
        string[] strTexts = new string[] { "1string", "2string", "3string" };

        Console.WriteLine("Enter some text:");

        // Accept the user's input
        string userInput = Console.ReadLine();

        // Update each string in the array by iterating through each one.
        for (int i = 0; i < strTexts.Length; i++)
        {
            strTexts[i] += userInput;
        }

        // Print each string by iterating through the updated array.
        foreach (string txt in strTexts)
        {
            Console.WriteLine(txt);
        }

        // Endless loop
        while (true)
        {
            // Request a command from the user
            Console.WriteLine("Type the command ('exit' to terminate):");
            string command = Console.ReadLine();

            // Determine if the user wishes to break out of the loop.
            if (command == "exit")
            {
                break;
            }

        }

        // Wait for the user to hit a key before exiting..
        Console.ReadKey();
    }
}
