using System;

//Delegates
// signature of delegate must match the signature of the functions, the delgat points to (i.e  - void, string,int etc )
/*
A delegate is a reference to a method. Whereas objects can easily be sent as parameters into methods, constructor or whatever, 
methods are a bit more tricky. But every once in a while you might feel the need to send a method as a parameter to another method, and that's when you'll need delegates.
*/
public delegate void Hellofunctiondelgate(string message);

class Program
{
    public static void Main()
    {
        // A delegate is a type safe function pointer
        Hellofunctiondelgate obj = new Hellofunctiondelgate(Hello);
        obj("Shivam");

    }
    public static void Hello(string strmessage)
    {
        Console.WriteLine(strmessage);
    }
}
