using System;

class AssignmentPart3
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

        // Here's the loop that's infinite
        while (true)
        {
            // Request a command from the user
            Console.WriteLine("Enter a command (type 'exit' to quit):");
            string command = Console.ReadLine();

            // Determine if the user wishes to break out of the loop.
            if (command == "exit")
            {
                break; // Exit the loop
            }

        }

        // Using "<" operator in the loop
        for (int i = 0; i < strTexts.Length; i++)
        {
            Console.WriteLine("Loop using '<' operator: " + strTexts[i]);
        }

        // Using "<=" operator in the loop
        for (int i = 0; i <= strTexts.Length - 1; i++)
        {
            Console.WriteLine("Loop using '<=' operator: " + strTexts[i]);
        }

        // Wait for the user to press a key before exiting
        Console.ReadKey();
    }
}
