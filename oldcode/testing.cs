using System;
public class Fruits{
  public  virtual  void print(){
        Console.WriteLine("Hello");
    }
}
public class Apple : Fruits{
   public override  void print(){
        Console.WriteLine("overwriteen");
    }
}
public class Test{
    public static void Main(string[] args){
        Apple a = new Apple();
        a.print();
    }
}