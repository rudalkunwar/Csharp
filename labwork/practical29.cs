using System;

public class Myexception : Exception { 
    
    public Myexception(string message) : base(message) {}
    
}

class Practical { 
    static void Main(string[] args) 
    { 
        try 
        { 
            throw new Myexception("Custom Exception"); 
        } 
        catch (Myexception ex) { Console.WriteLine("Custom Exception Caught: " + ex.Message); }
         
        } 
}
