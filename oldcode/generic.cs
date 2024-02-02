using System;
public class Test<T>
{
    private T data;
    public T idata {
        get{return this.data;}
        set{this.data = value;}
    }
}
public class Testing{
    public static void Main(string[] args){
        Test <string> s = new Test <string>();
        s.idata = "Rudal Kunwar";
        Console.WriteLine(s.idata);

        Test <float> f = new Test <float>();
        f.idata = 0.5f;
        Console.WriteLine(f.idata);
    }
}
