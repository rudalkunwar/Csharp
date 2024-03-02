using System;
public class Practical{
    delegate int mydeligate(int x , int y);
    public int Sum(int x , int y){
        return x+y;
    }
    public static void Main(string[] args){
        Practical p = new Practical();
        mydeligate d1 = new mydeligate(p.Sum);
        int sum = d1(18,12);
        Console.WriteLine("The sum is "+sum);
    }
}