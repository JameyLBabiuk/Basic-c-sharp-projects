using System;

class Program
{
    static void Main(string[] args)
    {
        PackageShippingEstimate();
    }

    static void PackageShippingEstimate()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        float packageWeight = float.Parse(Console.ReadLine());

        // If package weight is greater than 50, display an error message and end program
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Prompt user for package dimensions
            Console.Write("Please enter the package width: ");
            float packageWidth = float.Parse(Console.ReadLine());
            Console.Write("Please enter the package height: ");
            float packageHeight = float.Parse(Console.ReadLine());
            Console.Write("Please enter the package length: ");
            float packageLength = float.Parse(Console.ReadLine());

            // Calculate the total package dimensions
            float totalPackageDimensions = packageWidth + packageHeight + packageLength;

            // If package dimensions total exceeds 50, display an error message and end program
            if (totalPackageDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                // Calculate the shipping cost and display it to the user
                float quote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
                Console.WriteLine("Thank you!");
            }
        }
    }
}
