using System;
public class Tswap <Ts>
{
    public static void swap(Ts a,Ts b){
        Ts temp;
        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("The swapped value ")
    }
    public static void Main(string[] args)
    {
        swap()
    } 
}
