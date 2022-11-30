using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    // find out the number of odd digits fron the number  
    class Sum8

    {
        static void Main(string[] arg)
        {
            int count = 0;
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 2;
                int result = 0;
                result = result + digit;
                num = num / 10;
                if (result % 2 != 0)
                {
                    count++;

                }

            }
            Console.WriteLine(count);

        }
    }
}
