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

            Constants c = new Constants();
            c.AcceptRadius();
            c.AreaOfCirle();
            c.Display();

            IfStatements statement = new IfStatements();
            statement.DrinkBeer();

            SwitchStatement switchStatement = new SwitchStatement();
            switchStatement.GiveRemarks();

            Loops loops = new Loops();
            loops.WhileLoop();
            loops.DoLoop();


        }
    }
}
