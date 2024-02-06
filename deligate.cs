using System;

public delegate int Mymultidel();

public class Test {
    public static void Main(string[] args) {
        Mymultidel d1 = classA.method1;
        Mymultidel d2 = classB.method2;
        Mymultidel d = d1 + d2;
        Console.WriteLine(d());
    }
}

public class classA {
    public static int method1() {
        Console.WriteLine("Class A");
        return 10;
    }
}

public class classB {
    public static int method2() {
        Console.WriteLine("Class B");
        return 20;
    }
}
