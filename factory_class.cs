using System;

//.....................................FACTORY PATTERN.........................................

// we create a factory class which is used to hide the implementation code of object creation and only expose the methods

// we do not show the main class, that which object class we will use

// we create interface, and pass different object to interface, simplifies object creation

// creating object without exposing the instantiation logic to the client (i.e not using new keyword to instantiate class obj)
// reffering to the newly created objects using common interface

public class Program
{
    // this main porgram is called as client program
    public static void Main()
    {
        Console.WriteLine("Enter your object type");
        string type = Console.ReadLine();

        // static method can be called directly by class name, we don't require to create its object thats why factory class is
        // declared static

       I1 obj = Createobj.getobject(type);

        Console.WriteLine(obj.getfname());

    }
    // factory pattern class

    // public class Createobj (cannot use public to define below interface ) 

    class Createobj
    {
        // writing I1 here -> means it returns interface
        
        public static I1 getobject(string typeofobj)
        {
            I1 obj = null;
            if(typeofobj.ToLower() == "student")
            {
                obj = new Student();
            }
            else
            {
                obj = new Teacher();
            }
            return obj;
        }
    }

    interface I1
    {
        string getname();
        string getfname();
    }
    class Teacher :I1
    {
        public string getname()
        {
            return "teacher name";
        }
        public string getfname()
        {
           
           return "teacher fatherr name";
            
        }
    }
    
    class Student: I1
    {
        public string getname()
        {
            return "student name";
        }
        public string getfname()
        {
            
            return "student fatherr name";
            
        }


    }
}
