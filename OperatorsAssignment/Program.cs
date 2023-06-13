using System;

public class Employee
{
    // Employee Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloaded "==" operator
    public static bool operator ==(Employee first_emp, Employee second_emp)
    {
        // validate that the objects are either null or their Ids are equal
        return (ReferenceEquals(first_emp, null) && ReferenceEquals(second_emp, null)) ||
               (!ReferenceEquals(first_emp, null) && !ReferenceEquals(second_emp, null) && first_emp.Id == second_emp.Id);
    }

    // Overloaded "!=" operator  that is required when overloading "=="
    public static bool operator !=(Employee first_emp, Employee second_emp)
    {
        return !(first_emp == second_emp);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Two instances of the Employee object
        Employee first_emp = new Employee();
        first_emp.Id = 1;
        first_emp.FirstName = "Jamey";
        first_emp.LastName = "Babiuk";

        Employee second_emp = new Employee();
        second_emp.Id = 2;
        second_emp.FirstName = "Sam";
        second_emp.LastName = "Green";

        // Making a comparison of the two Employee objects through the use overloaded operators
        bool equalEmps = first_emp == second_emp;
        bool nonEqualEmps = first_emp != second_emp;

        // show the outcome
        // Expected: Are the employees equal? False
        Console.WriteLine($"Are the employees equal? {equalEmps}");    
        // Expected: Are the employees not equal? True    
        Console.WriteLine($"Are the employees not equal? {nonEqualEmps}");  
    }
}
