using System;
public class Ari{
    public int add(int a , int b){
        return(a+b);
    }
    public int sub(int a , int b){
        return (a-b);
    }
    public int mul(int a , int b){
        return (a*b);
    }
    public double div(int a,int b){
        try{
            if(b==0){
                throw new DivideByZeroException("Cannot divide by zero");
            }else{
            return ((double)a/b);

            }
        }
        catch(Exception e){
            Console.WriteLine("Cannot divide by 0"+e);
            return double.NaN;
        }
    }
    public static void Main(string[] args){
        int choice;
        Console.WriteLine("Enter two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose your operation\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n");
        choice = Convert.ToInt32(Console.ReadLine());
        Ari obj = new Ari();
        switch(choice){
            case 1: 
            int sum = obj.add(a,b);
            Console.WriteLine("The Addition of the number is :"+sum);
            break;
            case 2: 
            int subt = obj.sub(a,b);
            Console.WriteLine("The Subtraction of the number is :"+subt);
            break;
            case 3: 
            int mult = obj.mul(a,b);
            Console.WriteLine("The Multiplication of the number is :"+mult);
            break;
            case 4: 
            double divt = obj.div(a,b);
            Console.WriteLine("The Division of the number is :"+divt);
            break;
            default:
            Console.WriteLine("Enter the valid Choise");
            break;
        }
    }

}