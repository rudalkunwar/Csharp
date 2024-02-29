using System;
public class Practical2{
    public static void Main(string[] args){
        Console.WriteLine("Enter the row of Array");
        int row = Convert.ToInt32(Console.ReadLine());
        int[][] jarray = new int[row][];
        for(int i = 0; i<row;i++){
        Console.WriteLine("Enter the number of Column");
        int col = Convert.ToInt32(Console.ReadLine());
        jarray[i] = new int[col];
        Console.WriteLine($"Enter the values of {i+1} Column");
        for(int j = 0; j < col ; j++){

            jarray[i][j] = Convert.ToInt32(Console.ReadLine());
        }
        }
        Console.WriteLine("Your jagged array is:");
        foreach(int[] arr in jarray){
            foreach(int num in arr){
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }
    }
}