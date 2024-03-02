using System;
public class Practical{
    delegate void multidel();
    public void displayName(){
        Console.WriteLine("This is to display name ");
    }
     public void displayNumber(){
        Console.WriteLine("This is to display Number ");
    }
    public static void Main(string[] args){

        Practical p = new Practical();
        multidel d1 = new multidel(p.displayNumber);
        d1+=p.displayName;
        d1();
    }
}