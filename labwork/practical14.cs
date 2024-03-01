using System;
public static class Sclass{
    public static void sdisplay(){
        Console.WriteLine("I am static method from static class");
    }
}
public class Practical{
    public static void display(){
        Console.WriteLine("I am static method from non static class");
    }
    public static void Main(string[] args){
        Sclass.sdisplay();
        display();
    }
}