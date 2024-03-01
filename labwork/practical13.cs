using System;
public class Practical{
    private int num;
    public string name{get;set;}
    public int number{
        get{
            return num;
        }
        set{
            this.num = value;
        }
    }
    public static void Main(string[] args){

        Practical p = new Practical(){name="rudal"};
        p.number = 50;
        Console.WriteLine("The number is "+p.number);
        Console.WriteLine("The Name is "+p.name);

    }
}