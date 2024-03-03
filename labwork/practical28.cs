using System;
public class Practical{
    public static void Main(string[] args){
        try{
            int a = 5;
            int b = 0;
            int div = a/b;
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}