using System;
namespace encapsulationExample
{
    public class Example
    {
        private int x;
        public int getX(int x)
        {
            return x;
        }
        public void setX(int x)
        {
            if (x > 0)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("Enter possitive value");
            }
        }
    }
    public class dirver
    {
        public static void Main(String[] args)
        {
            Example exm = new Example();
            /* exm.setX(-1);
            exm.setX(10); */
            Console.WriteLine(exm.getX(10));
            Console.WriteLine(exm.getX(-1));
        }
    }
}