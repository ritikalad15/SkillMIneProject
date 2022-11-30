using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
   /* class XobinTestQ
    {
        static void Main(string[]args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1);

                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);

            }
        }
    }*/
    


    class Factor
    {   

        static void Main(string[] args)
        {
            int fact = 1;
            int num = int.Parse(Console.ReadLine());
            int i;
            for ( i=1; i<=num; i++)
            {
                fact = fact * i;
                Console.WriteLine(fact);

            }
        }
        
    }

    
}
