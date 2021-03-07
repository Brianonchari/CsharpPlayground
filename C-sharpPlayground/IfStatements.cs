using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharpPlayground
{
    
    class IfStatements
    {
        int age;
        const int drinkingAge = 18;

        public void DrinkBeer()
        {
            Console.WriteLine("Enter your age please:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are too young to drink mate.You are {0} years old. You should be atleast {1}.",age,drinkingAge);
            }
            else
            {
                Console.WriteLine("What  can I get you?");
            }
        }
    }


}
