using System;
public class Practical{
    public Practical(){
        Console.WriteLine("I am default constructor");
    }
    public Practical(string name){
        Console.WriteLine("I am parameterized constructor");
    }
    ~Practical(){
        Console.WriteLine("I am destructor");

    }
    public static void Main(string[] args){
        new Practical();
        new Practical("Hello");
        
    }
}