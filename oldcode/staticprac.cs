using System;
public static class Area{
    public static void Rectangle(int l , int b){
        Console.WriteLine("The are of rectangle is :"+(l*b));
    }
     public static void Square(int l){
        Console.WriteLine("The are of Square is :"+(l*l));
    }
}
public class Perimeter{
     public static void Rectangle(int l , int b){
        Console.WriteLine("The Perimeter of rectangle is :"+(2*(l+b)));
    }
    public void Square(int l){
        Console.WriteLine("The Perimeter of Square is :"+(4*l));
    }
}
public class Test{
    public static void Main(string [] args){
        Area.Rectangle(50,20);
        Area.Square(10);

        Perimeter p = new Perimeter();
        Perimeter.Rectangle(50,20);
        p.Square(10);
    }
}