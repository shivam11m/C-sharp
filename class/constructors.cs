using System;

//namespace cannot directly contains methods , the methods has to be inside class

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.printfullname();
        }
    }

    class Customer
    {
        //this keyword refers to instance of this  class or object of this class

        string fn, ln;

        // CONSTRUCTOR HAVE SAME NAME AS CLASS NAME
        // IF WE DO NOT CREATE CONSTRUCTOR, A DEFAULT PARAMETER LESS CONSTRUCTOR IS AUTMATICALLY PROVIDED
        

       // a constructor is used to intialize class field and is automatically called whenever we create an instance of a class

        // parameter less constructor, and it gets called when we do not provide any input in obj field, the parameter less construtr
        // calls below parameterized constructor. ........... run the programing by removing fields

        public Customer(): this("no first name provided", "no last name provided")
        {

        }

        public Customer(string fn, string ln)
        {
            this.fn = fn;
            this.ln = ln;
        }
        public void printfullname()
        {
            Console.WriteLine($"full name is {fn} {ln} ");
        }

        // destructors cleans  up the resources that class was holding during its life time
        // destructors are automatically called by garbage collectors when it tris to clean the objects from the  memory

        ~Customer()
        {
            //clean up code
        }

    } 
   
}
