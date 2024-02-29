using System;
public class Practical6{
    public static void Main(string[] args){
        Console.WriteLine("Enter the time in seconds");
        int time = Convert.ToInt32(Console.ReadLine());
        int min = time / 60;
        int sec = time-(min*60);
        int hours = 0;
        if(min>=60){
            hours = min /60;
            min = min - hours*60;
        }
        Console.WriteLine($"The time is {hours} hours : {min} min : {sec} sec");
    }
}