using System;
//Q:- interview questions, a class inherits from 2 interfeces and both the interfeces have same mtd name then should class should
// implement method for both the interfaces


// two interface got same method name then we need explicit interface implementation
interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}
public class Program: I1,I2
{
    /* when we are implementing interface explicitly, remove access modifier  public
        
    public void InterfaceMethod()
    {
        Console.WriteLine("I1 interface method");
    }
    */
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface called");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface called");
    }
    public static void Main()
    {
        /*
         Program p = new Program();
        p.InterfaceMethod();    */
        Program p = new Program();

        // typecasting 
        ((I1)p).InterfaceMethod();
        ((I2)p).InterfaceMethod();

        //or we can do this as well :-
        I1 i1 = new Program();
        I2 i2 = new Program();
        i1.InterfaceMethod();
        i2.InterfaceMethod();
    }
}
