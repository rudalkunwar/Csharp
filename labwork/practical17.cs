using System;
public class Practical{
    string name{get;set;}
    public static Practical operator +(Practical p1,Practical p2){
        Practical p3 = new Practical();
        p3.name = string.Concat(p1.name,p2.name);
        return p3;
    }
    public static void Main(string[] args){
        Practical p1 = new Practical(){name="rudal "};
        Practical p2 = new Practical(){name = "kunwar"};

        Practical p3 = new Practical();
        p3 = p1+p2;
        Console.WriteLine("The name is "+p3.name);
    }
}