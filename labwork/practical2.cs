using System;
public class Practical2{
    public static void Main(string[] args){
        Console.WriteLine("Enter the radius of the outer circle");
        double R = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the radius of the inner circle");
        double r = Convert.ToDouble(Console.ReadLine());
        double Area = Math.PI * (R * R - r * r);
        Console.WriteLine("Area between the concentric circle is: " + Area);
    }
}