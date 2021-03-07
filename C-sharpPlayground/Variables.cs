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
        int b;
        int c;
        public void AcceptDetails()
        {

            a = 10;
            b = 20;
            c =30;
        }



        public void DisplayVariables ()
        {
            Console.WriteLine("a :{0}" ,a);
            Console.WriteLine("b:{0}," ,b);
            Console.WriteLine("c:{0}",c);
      
        }
    }
}
