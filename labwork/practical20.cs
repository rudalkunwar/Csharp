using System;
public interface Name{
    public void Display();
}
public class Test:Name{
    public void Display(){
        Console.WriteLine("Implementing interface");
    }
    public static void Main(string[] args){
        Test t = new Test();
        t.Display();
    }
}