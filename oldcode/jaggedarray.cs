using System;
public class JaggedArray{
    public static void Main(string[] args){
        string[][] names = new string[2][];
        Console.WriteLine("Enter the string values");
        for(int i = 0 ; i<2;i++){
            Console.WriteLine($"Input length of the array : {i+1}");
            int arrlength = Convert.ToInt32(Console.ReadLine());
            names[i]=new string[arrlength];
            Console.WriteLine($"Input length of the array : {i+1}");
            for(int j=0;j<names[i].Length;j++){
                names[i][j] = Console.ReadLine();
            }
        }
          Console.WriteLine("The required Array:");
        for(int i = 0 ; i<2;i++){

            for(int j=0;j<names[i].Length;j++){
                Console.Write(names[i][j]);
            }
            Console.WriteLine();
        }
    }
}