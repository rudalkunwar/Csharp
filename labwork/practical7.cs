using System;
public class Practical7{
    public static void Main(string[] args){

        Console.WriteLine("Enter First number: a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second number: b");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The number before swap  a:{a} b:{b} ");
        a = a + b;
        b = a - b ;    
        a = a - b;
        Console.WriteLine($"The number after swap  a:{a} b:{b} ");

    }
}