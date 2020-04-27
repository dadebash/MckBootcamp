using System;
namespace ConstructorExamples
{
    class Geek
    {
        int num;
        string name;
        //create a constructor(deafault constructor): constructor name must be same with the class name
        /* Geek()
        {
            Console.WriteLine("default constructor called");
        } */
        //Create a parameterized constructor
        Geek(int num, string name)
        {
            this.num = num;
            this.name = name;
        }
        // public static void Main(String[] args)
        // {
        //     Geek g = new Geek(100, "Deb!");

        //     /*
        //        Here we have not defined the variables.
        //        So default constructor provides default values.
        //        for int num it should be 0 and for name it should be Null
        //      */
        //     Console.WriteLine("the value of num variable is:: " + g.num);
        //     Console.WriteLine("the value of name variable is:: " + g.name);
        // }
    }
}
