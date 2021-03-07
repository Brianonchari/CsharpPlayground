using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharpPlayground
{
    class Rectangle
    {
        double lenth;
        double width;

        public void AcceptDetails()
        {
            lenth = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return lenth * width;
        }

        public void Display()
        {
            Console.WriteLine("Lenth: {0}", lenth);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());

        }
        /**static void Main(string[] args)
         {
               Rectangle r = new Rectangle();
               r.AcceptDetails();
               r.Display();
               r.GetArea();
               Console.ReadLine();
           }
          **/
    }
}
