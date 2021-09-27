using System;

// more example -- general  surgeon vs some  specialized one
//inheritance  - code reuse

// c# does  not support multi class inheritance (i.e . public class x: y,z) wrong (can inherit class y, z at same time)



public class Employee
{
    // has to be public to access outside  the class
    public string firstname;
    public string lastname;
    public string email;

    public void printfullname()
    {
        Console.WriteLine( firstname +" "+ lastname);
    }
}
// now fulltimeemployee can access the members of employee class

public class FulltimeEmployee : Employee
{
    // has to public to access it outside the class
    public float yearlysalary;
}

public class ParttimeEmployee : Employee
{
    
    public float hourlyrate;
}

//multi level  class inheritance is allowed

public class A: ParttimeEmployee
{

}

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee  fte = new FulltimeEmployee();
            fte.firstname = "shivam";
            fte.lastname = "mulewa";
            fte.yearlysalary = 1200;
            fte.printfullname();




        }
    }
 
}
