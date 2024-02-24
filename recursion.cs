using System;
public class Recur{
    public int recur(int x){
        if(x==0){
            return 1;
        }else{
            return x * recur(x-1);
        }
    }
    public static void Main(string [] args){
        int x;
        Console.WriteLine("Enter the value");
        x = Convert.ToInt32(Console.ReadLine());

        Recur r = new Recur();
        int value = r.recur(x);
        Console.WriteLine("The factorial value "+value);

    }
}