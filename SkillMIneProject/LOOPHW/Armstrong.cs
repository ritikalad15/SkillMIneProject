using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.LOOPHW
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;
            }
            num = temp;
            if (temp == num)
            {
                Console.WriteLine("number is Amstrong");

            }
            else
            {
                Console.WriteLine("number is not Armstrong");

                    
            }
        }
    }
}
