using System;
public class Vehicle{
    public string oil = "Petrol";
}
public class Bike:Vehicle{
    string color;
    public Bike(string color){
        this.color = color;
    }
    public void display(){
        Console.WriteLine("The vehicle type is "+oil);
        Console.WriteLine("The color of bike is:"+color);
    }
}
public class Test{
    public static void Main(string[] args){
        Bike b1 = new Bike("Blue");
        b1.display();
        Bike b2 = new Bike("Yellow");
        b2.display();
    }
}