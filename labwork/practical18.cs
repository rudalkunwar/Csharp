using System;
public class Gclass <Type>{
   public Type name;

}
public class Gmethod{
    public static void  displayArray <T> (T[] array){
        foreach(var item in array)
        {
            Console.Write(" "+item);
        }
    }
    public static void Main(string[] args){
        int[] iarray = {1,2,4,54,34,23,43};
        string[] sarray = {"rudal","aakash","pratik","basanta","soham","lalit"};
        Console.WriteLine("Generic Mehod for integer and string array display");
        displayArray(iarray);
        Console.WriteLine();
        displayArray(sarray);

        Gclass <string> str = new Gclass<string>();
        str.name = "Rudal";
        Console.WriteLine("\nThe generic class "+str.name);
    }
}