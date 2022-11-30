using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    //Sum of Odd number btween 1 to 20 
    class Sum1
    {
        static void Main(string[]args)
        {
            int count = 0;
            for(int i = 1; i <= 20; i++)
            {
                while (i % 2 != 0)
                {
                    count ++;
                    Console.WriteLine(i);
                    i++;
                }
            }
            Console.WriteLine("sum of odd nmuber" + count);
        }
    }
}
