using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class GreatestNum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 50;
            num2 = 60;
            num3 = 70;
            
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Num1 is Largest");
                }
                else
                {
                    Console.WriteLine("Num3 is Largest");
                }

            }
             else if (num2 > num3)
             {
                Console.WriteLine("Num2 is Largest");

             }
              else
              {
                Console.WriteLine("Num3 is Largest");
              }
            
               

            
        }
    }
}
