using System;
public class Shape{
    public virtual void ComputeArea(){

    }
}
public class Rectangle : Shape{
    int l;
    int b;
    public Rectangle(int l,int b){
        this.l=l;
        this.b=b;
    }
      public override void ComputeArea(){
        Console.WriteLine("The are of the Rectangle is :"+(l*b));
    }
}
public class Square : Shape{
        int l;
    public Square(int l){
        this.l=l;
    }
      public override void ComputeArea(){
        Console.WriteLine("The are of the Square is :"+(l*l));
    }
}
public class Test(){
    public static void Main(string[] args){
        Square s = new Square(10);
        Rectangle r = new Rectangle(5,10);
        s.ComputeArea();
        r.ComputeArea();
    }

}