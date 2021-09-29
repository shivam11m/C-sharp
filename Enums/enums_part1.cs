using System;

public class Customer
{
    public string name { get; set; }
    public Gender Gender { get; set; }


  
}
// creating a enum

public enum Gender
{
    Unknown,
    Male,
    Female
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
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                name = "Marry",
                Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                name = "sam",
                Gender = Gender.Unknown
            };
            foreach(Customer customer in customers)
            {
                Console.WriteLine( "Name = {0} && Gender={1}", customer.name, GetGender(customer.Gender));

            }
        }



        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";

            }
        }
    }
 
}
