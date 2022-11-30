using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class Sum3
    {
        // Display number between 1 to 50 and just skip Number divisible by 5
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 50)
            {
                if (i % 5 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
