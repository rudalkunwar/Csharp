using System;
public class Practical{
    public static void Main(string[] args){
        Console.WriteLine("Enter the length of Array");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] num = new int[len];
        Console.WriteLine("Enter the Values of Array");
        for(int i = 0 ; i < len ; i++){
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0 ; i<len;i++){
            for(int j = i+1 ; j<len ; j++){
                if(num[i]>num[j]){
                    int temp = num[i];
                    num[i]=num[j];
                    num[j]=temp;
                }
            }
        }
        Console.WriteLine("The sorted Array:");
        foreach(int value in num){
            Console.Write(value+" ");
        }
        
    }
}