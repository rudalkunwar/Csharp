using System;
public class Test{
    public static void rswap(ref int a , ref int b){
        int temp =  a ; 
         a =  b;
         b = temp;
        Console.WriteLine("a = : " + a + "b = : "+b);
    }

    public static void vswap(int c , int d){
        int temp = c;
        c = d;
        d = temp;
         Console.WriteLine("c = : " + c + "d = : "+ d);
    }
    public static void Main(string [] args){


        int a = 10 , b = 50;
        int c = 10 , d = 50;
        Console.WriteLine("Before swap : a = :" + a + " b = : "+b);
        Console.WriteLine("Before swap : c = :" + c + " d = : "+d);
        rswap(ref a,ref b);
        Console.WriteLine(" After swapped origianal variables : a = :" + a + " b = : "+b);
        vswap(c,d);
        Console.WriteLine("After swap original variables : c = :" + c + " d = : "+d);

    }
}