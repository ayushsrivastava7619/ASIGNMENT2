using System;

class Employee
{

    public string Name;
    public int Age;
    public double Salary;

    
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary}"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee emp = new Employee("John Doe", 30, 50000.0);

        
        emp.DisplayDetails();
    }
}
