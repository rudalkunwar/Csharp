using System;
interface Shape{
     void computeArea();
}
public class Rectangle:Shape{
    int l,b;
    public Rectangle(int l,int b){
        this.l=l;
        this.b=b;
    }
    public void computeArea(){
        Console.WriteLine("The area of the rectangle is :"+(l*b));
    }
}
public class Test{
    public static void Main(string[] args){
        Rectangle r = new Rectangle(10,20);
        r.computeArea();
    }
}