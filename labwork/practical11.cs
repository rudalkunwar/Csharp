using System;

public class Employee
{
    string name;
    int age;
    string address;

    public Employee(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void Display()
    {
        Console.WriteLine("The employee name is: " + name);
        Console.WriteLine("The employee age is: " + age);
        Console.WriteLine("The employee address is: " + address + "\n");
    }

    public static void Main(string[] args)
    {
        Employee e1 = new Employee("Aakash", 21, "Gaidakot");
        Employee e2 = new Employee("Basanta", 22, "Kathmandu");
        Employee e3 = new Employee("Aakash", 21, "Gaidakot");

        e1.Display();
        e2.Display();
        e3.Display();
    }
}
