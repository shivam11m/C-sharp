using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 2;
            Console.WriteLine($"value of k is : {k}");

            // numbers() is a not static method so object refrence is required to access the non static methods

            Program p = new Program();
            p.numbers();

            // static method,  instantiation not required
            Console.WriteLine("odd numbers: ");
            oddnumbers();

        }
        public void numbers()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        static void oddnumbers()
        {
            int num = 1;
            while (num <= 20)
            {
                if (num%2==1) Console.WriteLine( num);
                num += 2;
            }
        }
    }
}
