using System;
public class Prop{
    private int x{get,set}; 
    public static void Main(string[] args){
        Prop p = new Prop();
        p.x = 10;
        Console.WriteLine("the value is 0"+p.x);
    }
}