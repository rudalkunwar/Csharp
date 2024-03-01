using System;
public abstract class Practical{
    public abstract void Display();
}
public class Test:Practical{
    public override void Display(){
        Console.WriteLine("I am overridden method of abstract class");
    }
    public static void Main(string[] args){
        Test t = new Test();
        t.Display();
    }
}