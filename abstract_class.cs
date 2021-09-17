using System;


// We cannot create instance of abstract class, abstract class can only be used as base class.
// sealed means can't be used as base class, so abstract class cannot be sealed
public abstract class Customer
{
    //abstract method --- now abstract method cannot have implementation, some class will derive it to provide it implementation.
    public abstract void print();

    public void print1()
    {
        Console.WriteLine("shivam is good");
    }

}

// Program class is inheriting from customer class, so if non abstract class is inherit from abstract class then non abstract class
// has to provide implementation of all the abstract class methods.



public class Program : Customer
{
    // override keyword is needed to provide the implementation
    public override void print()
    {
        Console.WriteLine("abstract print method implementation");
    }

    public static void Main()
    {
        Program p = new Program();
        p.print();

    }
}
