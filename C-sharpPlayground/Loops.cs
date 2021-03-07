using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharpPlayground
{
    class Loops
    {
        int num = 10;
        public void WhileLoop()
        {
            while (num < 20)
            {
                Console.WriteLine("Value of num is {0}",num);
                num++;
            }
        }

        public void DoLoop()
        {
            for(int num = 10; num <20; num = num + 1)
            {
                Console.WriteLine("Value of num is {0}",num);
            }
        }

    }
}
