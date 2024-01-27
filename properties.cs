using System;
public class Prop{
    private string name;
    public string Pname{
        get{ return name;}
        set{this.name=value;}
    }
}
public class useProp{
    public static void Main(string[] args){
        Prop p = new Prop();
        p.Pname = "'kunsrudal'";
        Console.WriteLine(p.Pname);
    }
}