using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{

    // find the even digits from the number 
    class Sum7
    {
        static void Main(string[]aargs)
        {
            int count = 0;
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 10;
                int result = 0;
                result = result +digit;
                num = num / 10;
                if (result % 2 == 0)
                {
                    count++;
                   
                }
                
            }
            Console.WriteLine(count);

        }
    }
}
