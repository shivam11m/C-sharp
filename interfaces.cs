using System;

// common convention to use capital I before writing interface name.

// interaces has only has declaration and interface members are public by default
// interface implementation give compile time error
interface ICustomer1
{
    //public void print() error as its public by default
    //int id - error as interface cannot have filds
    void print1();
}

interface ICustomer2 : ICustomer1
{
    void print2();
}

// class allow multiple interface inheritance at the same time

public class Customer : ICustomer2
{
    // when class inherites interface it has to provide implementation for interface
  
    public void print2()
    {
        Console.WriteLine("I2 method");

    }

    public void print1()
    {
        Console.WriteLine("my first interface program");
    }
}

public class Sample
{

}

// A class cannot inherit from more then one class at the same time (i.e) - public class Program : Customer, Sample
// so, multiple class inheritance not possible whereas multiple interface inheritance is possible

public class Program 
{
    public static void Main()
    {
        // we cannot create an instance of an interface (i.e) - Icustomer obj =new Icustomer();
        Customer obj = new Customer();
        obj.print1();
        obj.print2();

        // An interface refrence variable can refrence to a derived class object

        ICustomer1 obj1 = new Customer();
        obj1.print1();
    }
}
