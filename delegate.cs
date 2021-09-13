using System;

//Delegates
// signature of delegate must match the signature of the functions, the delgat points to (i.e  - void, string,int etc )

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
