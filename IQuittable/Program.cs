using System;

// Definition of the IQuittable interface
public interface IQuittable
{
    void Quit();
}

// Employee class inheriting from the IQuittable interface
public class Employee : IQuittable
{
    public string Name { get; set; }

    public void Quit()
    {
        Console.WriteLine("The New Employee has decided to quit their job.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an object of type IQuittable using polymorphism
        IQuittable quittableEmployee = new Employee();

        // Call the Quit() method on the IQuittable object
        quittableEmployee.Quit();

        Console.ReadLine();
    }
}
