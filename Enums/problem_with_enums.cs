using System;

public class Customer
{
    public string name { get; set; }
    public int Gender { get; set; }


  
}

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                name = "Mark",
                Gender = 1
            };

            customers[1] = new Customer
            {
                name = "Marry",
                Gender = 2
            };

            customers[2] = new Customer
            {
                name = "sam",
                Gender = 0
            };
            foreach(Customer customer in customers)
            {
                Console.WriteLine( "Name = {0} && Gender={1}", customer.name, GetGender(customer.Gender));

            }
        }

        // problem
        // how do we know that 
        // 0 corresponds to unkown
        // 1 correspond to male and so on
        // so, we need to see documentation for what kind of integers has which gender so program  becomes unavailable

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";

            }
        }
    }
 
}
