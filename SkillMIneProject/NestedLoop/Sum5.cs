using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    // to check number is spy or not
    class Sum5
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result1 = 0, result2 = 0;
            while (num > 0)
            {
                int num1 = num % 10;
                result1 = result1 + num1;
                result2 = result2 + num1;
                num = num / 10;
            }
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            if (result1 == result2)
            {
                Console.WriteLine("Num is Spy");
            }
            else
            {
                Console.WriteLine("Num is  not Spy");
            }
        }
    }
   
}
