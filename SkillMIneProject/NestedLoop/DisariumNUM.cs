using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class DisariumNUM
    {
        static void Main (string[]args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            
            while (num< 0)
            {
                int digit=num% 10;
                num = num / 10;


            }
        }
    }
}
