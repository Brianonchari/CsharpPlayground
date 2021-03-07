using System;
using System.Collections.Generic;
using System.Text;

/*
Declaring and initializing variables 
*/

namespace C_sharpPlayground
{
    class Variables
    {
        int a;
        double b;
        short c;
        int num; 
        public void AcceptDetails()
        {

            a = 10;
            b = 20;
            c =30;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
        }



        public void DisplayVariables ()
        {
            Console.WriteLine("a :{0}" ,a);
            Console.WriteLine("b:{0}," ,b);
            Console.WriteLine("c:{0}",c);


      
        }
    }
}
