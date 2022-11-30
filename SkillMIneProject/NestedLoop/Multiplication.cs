using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("display table 1 to 5 ");
            for (i = 1; i <= 10; i++)
            {

                for (j = 1; j <= 5; j++)
                {

                    Console.Write((i * j) + "\t");

                }
                Console.WriteLine(" ");
            }

        }
            
            

        
    }
}

