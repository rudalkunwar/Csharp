using System;
public class JaggedArray{
    public static void Main(string[] args){
        int[][] Jarr = new int [2][];
        Console.WriteLine("Enter the values of jagged arrays");
        for(int i = 0 ; i < 2 ; i++){
            Console.WriteLine($"Enter the length array :{i + 1} ");
            int arrlength = Convert.ToInt32(Console.ReadLine());
            Jarr[i]= new int[arrlength];
            for(int j=0; j < arrlength;j++ ){
                Console.WriteLine($"Enter the values of:{i+1}array");
                Jarr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i = 0 ; i < 2 ; i++){
            for(int j = 0 ; j < Jarr[i].Length;j++){
                Console.Write(Jarr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}