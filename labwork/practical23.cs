using System;
    public delegate void Myeventhan();
public class Practical{
    public static event  Myeventhan add;
    public static void Nepal(){
        Console.WriteLine("This is Nepal");
    }
    public static void India(){
        Console.WriteLine("This is India");
    }  
    public static void America(){
        Console.WriteLine("This is America");
    }
    public static void Main(string[] args){

        add += new Myeventhan(Nepal);
        add += new Myeventhan(India);
        add += new Myeventhan(America);
        add.Invoke();
    }
}