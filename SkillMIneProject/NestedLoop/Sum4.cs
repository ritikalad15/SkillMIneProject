using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class Sum4
    {
        // Sum of num btwn 1 to 20 if num >10 Stop performing Addition 
     
        static void Main (string []args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
                if (sum == 10)
                {
                    break;

                }
                Console.WriteLine(sum);

            }
        }
    }
}
