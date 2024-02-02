using System;
//  class Test{
//     public static void Main(string[] args){
//         int[] num = new int[10];
//         Console.WriteLine("Enter 10 numbers");
//         for(int i = 0;i<10;i++){
//             num[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         for(int i = 0;i<10;i++){
//             for(int j = i+1;j<10;j++){
//                 if(num[i]>num[j]){
//                 int temp;
//                 temp = num[i];
//                 num[i]=num[j];
//                 num[j]=temp;
//                 }
//             }
//         }
//          Console.WriteLine("After sort");
//          for(int i = 0;i<10;i++){
//             Console.WriteLine(num[i]);
//         }
//     }
    
// }
class Test{
    public static void Main(string[] args){
        string[,] CountryCapital = new string[3,2];
        Console.WriteLine("Enter country capital and then the capital city");
        for(int i = 0;i<5;i++){
            for(int j=0;j<2;j++){
                CountryCapital[i,j] = Console.ReadLine();
            }
        }
        Console.WriteLine("Your intputs ");
        for(int i = 0; i<5;i++){
            for(int j=0;j<2;j++){
                Console.Write(CountryCapital[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
