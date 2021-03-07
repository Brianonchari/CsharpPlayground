using System;
using System.Collections.Generic;
using System.Text;

/**
 * Defining and initializing constants
 * Constants are defined usiing const keyword
 * const <data_type> <constant_name> = value;**/
namespace C_sharpPlayground
{
   
    class Constants
    {
        const double pi = 3.14159;
        double radius;

        public void AcceptRadius()
        {
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public double AreaOfCirle()
        {
            return pi * radius * radius;
        }

        public void Display()
        {
            Console.WriteLine("Area of Circle with radius {0}: {1}",radius, AreaOfCirle());
        }
    }

 
}
