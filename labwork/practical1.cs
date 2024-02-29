using System;
public class Practical1{
    public static void Main(string[] args){
        Console.WriteLine("Enter the Number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((num%5==0)&&(num%7==0)?"Number is divisible by 5 and 7":"Number is not divisible by 5 and 7");
    }
}