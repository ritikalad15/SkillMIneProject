using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class Sum2
    {
        // count the number of digits
        static void Main(string[] args)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            while (n != 0)
            {

                count++;
                n = n / 10;
            }
            Console.WriteLine("Number of Digits="+count);

        }

    }
}
