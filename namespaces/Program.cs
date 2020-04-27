using System;

namespace firstnamespace
{
    class firstclass
    {
        public void methodone()
        {
            Console.WriteLine("this is under first namespace");
        }
    }
}

namespace secondnamespace
{
    class secondclass
    {
        public void methodtwo()
        {
            Console.WriteLine("this is under second namespace");
        }
    }
}

namespace namespaces
{
    class Program
    {
        /* static void Main(string[] args)
        {
            firstnamespace.firstclass f1 = new firstnamespace.firstclass();
            f1.methodone();
            secondnamespace.secondclass f2 = new secondnamespace.secondclass();
            f2.methodtwo();
        } */
    }
}
