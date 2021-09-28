using System;

//polymorphirsm enables us to invoke derived class method using a base class refrence variable at run time.
// virtual keyword indicates, that method can be overriden by any derived class

public class Employee
{
    // has to be public to access outside  the class
    public string firstname="FN";
    public string lastname="LN";
    public string email;

    // marking it virtual , it indicates to derived class that they can override it

    public virtual void printfullname()
    {
        Console.WriteLine( firstname +" "+ lastname);
    }
}
// now fulltimeemployee can access the members of employee class



public class FulltimeEmployee : Employee
{
    //if we dont  write override  then base class virtual implementation will be used and  not below one for this derived class
    public override void printfullname()
    {
        Console.WriteLine(firstname + " " + lastname+ " full time");
    }

}

public class ParttimeEmployee : Employee
{

    public override void printfullname()
    {
        Console.WriteLine(firstname + " " + lastname + " part time");
    }
}

public class TemprorayEmployee : Employee 
{
    public override void printfullname()
    {
        Console.WriteLine(firstname + " " + lastname + " temproray emp");
    }
}

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // a base class refrence can point to child class object but reverse is not possible

            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FulltimeEmployee();
            employees[2] = new ParttimeEmployee();
            employees[3] = new TemprorayEmployee();

            foreach(Employee e in employees)
            {
                e.printfullname();
            }


        }
    }
 
}
