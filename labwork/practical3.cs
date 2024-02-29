using System;
public class Practical3{
    public static void Main(string[] args){
        //sum = 1+2/2!+3/3!+4/4!+5/5!+..n
        Console.WriteLine("Enter the value of n");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = 1;
        double fact = 1;
        for(int i = 2; i <= n; i++){
            fact *= i;
            sum += i/fact;
        }
        Console.WriteLine("Sum of the series is: " + sum);
    }
}