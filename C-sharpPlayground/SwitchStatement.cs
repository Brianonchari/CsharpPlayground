using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharpPlayground
{
    class SwitchStatement
    {
        char grade = 'B';

        public void GiveRemarks()
        {
            Console.WriteLine("Enter Student Grade");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excelent");
                    break;

                case 'B':
                    Console.WriteLine("Good Work");
                    break;

                case 'C':
                    Console.WriteLine("Work Hard");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;

                   

            }
            
        }
    }
}
