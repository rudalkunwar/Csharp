using System;
public class Shape{
    public void ComputeArea(){
        Console.WriteLine("Hello i am compute Area");
    }
}
public class Quadrilateral : Shape{
    public void ComputeQuad(){
        Console.WriteLine("Hello i am compute Area Quad");
    }

}
public class Circle:Shape{
    public void computeCircle(){
        Console.WriteLine("Hello i am compute circle Area");
    }

}
public class Recatange:Quadrilateral{
    public void computeRect(){
        Console.WriteLine("Hello i am compute Area Rectangle");
    }

} 
public class Square:Quadrilateral{
    public void computeSquare(){
        Console.WriteLine("Hello i am compute Area Square");
    }

}
public class Test{
    public static void Main(string[] args){
        Square s = new Square();
        s.computeSquare();
        s.ComputeQuad();
        s.ComputeArea();

        Recatange r = new Recatange();
        r.computeRect();
        r.ComputeQuad();
        s.ComputeArea();

        Circle c = new Circle();
        c.computeCircle();
        c.ComputeArea();
    }
}