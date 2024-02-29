using System;
public class Practical{
    public static void Main(string[] args){
        Console.WriteLine("Enter the two String");
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        Console.WriteLine("The length of the first string is "+str1.Length);
        Console.WriteLine("The length of the Second string is "+str2.Length);
        Console.WriteLine("The concatination of two string is : "+string.Concat(str1,str2));
        Console.WriteLine(str1.Equals(str2)?"They are same string":"They are different string");
        Console.WriteLine(str1.Contains("a")?"The first string conatins a":"The first string doesnot contain a");
    }
}