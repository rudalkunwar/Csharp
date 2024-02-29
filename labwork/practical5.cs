using System;
public class Practical{
     public static int reverseNumber(int num){
            int rem , rev = 0;
            while(num!=0){
                rem  = num %10;
                rev = rev *10 + rem;
                num = num/10;
            }
            return rev;
        }
        public static int factorialNumber(int n){
            int fact = 1;
            for(int i = 2; i <= n; i++){
                fact *= i;
            }
            return fact;
        }
    public static void Main(string[] args){
        Console.WriteLine("1.Reverse of the Number\n2.Factorial of Number\n3.Volume of the Cube");
        Console.WriteLine("Enter the choice");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice){
            case 1:
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = reverseNumber(num);
            Console.WriteLine("Reverse of the number is: " + reverse);
            break;
            case 2:
            Console.WriteLine("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = factorialNumber(n);
            Console.WriteLine("Factorial of the number is: " + fact);
            break;
            case 3:
            Console.WriteLine("Enter the side of the cube :");
            double side = Convert.ToDouble(Console.ReadLine());
            double volume = side * side * side;
            Console.WriteLine("Volume of the cube is: " + volume);
            break;
            default:
            Console.WriteLine("Invalid Choice");
            break;
        }
       
    }
}