using System;

namespace C_sharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.GetArea();
            r.Display();
     
            Variables v = new Variables();
            v.AcceptDetails();
            v.DisplayVariables();
             Console.ReadLine();
        }
    }
}
