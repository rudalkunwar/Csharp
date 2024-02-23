using System;
public class Prop{
    private int x; 
    public int X{
        set{x = value;}
        get{return x;}
    }
    public static void Main(string[] args){
        Prop p = new Prop();
        p.X = 10;
        Console.WriteLine("the value is"+p.X);
    }
}