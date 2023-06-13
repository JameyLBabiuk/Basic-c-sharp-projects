using System;

namespace MathOperator
{
    // Creating the MathOperations class
    public class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformMathOperation(int num1, int num2)
        {
            // Perform calculation using the first integer.
            int fNumberResult =num1 * 2;
            Console.WriteLine($"The result of doubling the first integer is: {fNumberResult}");
        }
        // Make a void method with two integers as its arguments.
        public void DoMath(int num1, int num2)
        {
            // Place the first number in the method's initial math operation.
            int fNumberResult = num1 * 5;
            // To the screen, display the second integer.
            Console.WriteLine($"The second number is: {num2}");
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            // Class Instantiation
            MathOperations math = new MathOperations();

            // Call the class's method and enter two integers.
            math.DoMath(7, 9);

            // Call the class's method while naming the parameters.
            math.DoMath(num1: 3, num2: 10);

            // Before closing the console window, await user input.
            Console.ReadLine();
        }
    }
}