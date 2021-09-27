using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // passing by refrence to change the value by passing it to the function

            // if we dont't give refrernce then i and j are pointing to different memory locations

            int i = 0;
            simplemethod(ref i);
            Console.WriteLine(i);

            //If we want method to return more than one value , then out parameters are required;
            int add = 0, mul = 0;
            
            calc(10, 20, out add, out mul);

            Console.WriteLine($"sum is {add} and product is {mul}");

            //arrays passing
            int[] nums = new int[3];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;

            
            scanarray(nums);

            //or we can directly pass elements as well
            // params keywords is also  needed if we pass array like this
            `
            scanarray(1, 2, 3, 4, 5, 5, 6);

        }
       public static void simplemethod(ref int j)
        {
            j = 101;
        }

        public static void calc(int k1, int k2, out int add, out int mul)
        {
            add = k1 + k2;
            mul = k1 * k2;

        }
        public static void scanarray(params int[] nums)
        {
            
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
