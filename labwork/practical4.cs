using System;
public class Practical{
    public static void Main(string[] args){
       Console.WriteLine("Enter the number :");
       int num = Convert.ToInt32(Console.ReadLine());
       int rem , rev = 0;
       int temp=num;
       while(num!=0){
        rem  = num %10;
        rev = rev *10 + rem;
        num = num/10;
       }
       Console.WriteLine(num==temp?"Number is palindrome":"Number is not palindrome");
    }
}