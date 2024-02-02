using System;

interface Area {
    int CalculateArea(int a, int b);
}

interface Perimeter {
    int CalculatePerimeter(int a, int b);
}

class Calc : Area, Perimeter {
    public int CalculateArea(int l, int b){
        return l * b;
    }

    public int CalculatePerimeter(int l, int b){
        return 2 * (l + b);
    }
}

class Test {
    public static void Main(string[] args){
        Calc c = new Calc();
        int area = c.CalculateArea(4, 5);
        int peri = c.CalculatePerimeter(4, 5);

        Console.WriteLine("The area of the rectangle is " + area);
        Console.WriteLine("The perimeter of the rectangle is " + peri);
    }
}
