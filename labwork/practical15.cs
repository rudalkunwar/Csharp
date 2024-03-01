using System;
public class Animal{
    public virtual void makeSound(){
        Console.WriteLine("I am make Animal sound");
    }
}
public class Dog:Animal{
    public override void makeSound(){
        Console.WriteLine("I make dog sound");
    }
}
public class Practical{
    public void Add(int x , int y){
        Console.WriteLine("The addition of two number : "+(x+y));
    }
     public void Add(int x , int y,int z){
        Console.WriteLine("The addition of three number : "+(x+y+z));
    }
    public static void Main(string[] args){
        Dog d = new Dog();
        Practical p = new Practical();
        d.makeSound();
        p.Add(1,2,4);
        p.Add(2,10);
    }
}