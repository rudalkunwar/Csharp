using System;
public class Box{

    public double length;
    public double breadth;
    public double height;

    public double getVolume(){
        return length*breadth*height;
    }
    public void setLength(double length){
        this.length = length;
    }
     public void setBreadth(double breadth){
        this.breadth = breadth;
    }    
    public void setHeight(double height){
        this.height = height;
    }

    public static Box operator +(Box b1,Box b2){
        Box box = new Box();
        box.length = b1.length + b2.length;
        box.breadth = b1.breadth + b2.breadth;
        box.height = b1.height + b2.height;

        return box;
    }
}
public class Test{
    public static void Main(string[] args){
        Box box1 = new Box();
        box1.setLength(20.1);f
        box1.setBreadth(31.1);
        box1.setHeight(10.0);

        Box box2 = new Box();

        box1.setLength(11.1);
        box1.setBreadth(1.1);
        box1.setHeight(11.1);

        Box box3 = box1 + box2 ;
        Console.WriteLine(" Length :" + box3.length + "Breadth :" + box3.breadth + "height = " + box3.height);
        }
}