using System;

//namespace cannot directly contains methods , the methods has to be inside class
// class can be declared inside namespaces as well

class Circle
{
    // pi value is static field cause it is  consant through out the calculation
    //by marking field static, then in memory there will be only one copy that will be shared by all the objects like - ( c1,c2 ,c3..)
    // static members make program more efficient

    //static float _PI = 3.141F;

    // it is public so that it can be accessed outside the class
    public static float _PI;

    // r is instance field or non static fields
    int r;

    // if we pass the parameter inside constructors , then we can create function which requires this constructor parameters

    //static constructor are used to intialize static field and they dont have access modifiers
    // static constructor called before instance constructors
    // static constructor is called only once , cause it needs to intialize only once
    // static constructor are called before instance constructors

    static Circle(){
        Console.WriteLine(  "static constructor called");
        Circle._PI = 3.14F;
    }
    
    // access modifier has to be there and public to accesss it outside circle class
    public Circle(int radius)
    {
        Console.WriteLine("instance constructor called");
        this.r = radius; // r=radius will also work

    }
    //this keyword referes to instance of this class

    public float calculatearea()
    {
        // _Pi is static so the below line will give error because we are calling using this keyword
        // static members are invoked using name of the class and instance member are invoked using instance or an object of the clas
        //return this._PI * this.r * this.r; (wrong)

        // using name of calss to refer static members

        return Circle._PI * this.r * this.r;
    }


}


namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            float area1 = c1.calculatearea();
            Console.WriteLine("area = {0} ", area1);

            Circle c2 = new Circle(10);
            float area2 = c2.calculatearea();
            Console.WriteLine("area = {0} ", area2);


        }
    }

    
   
}
