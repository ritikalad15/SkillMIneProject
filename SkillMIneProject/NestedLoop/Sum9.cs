using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    // Sum of first digit and last Digit
    class Sum9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int num = int.Parse(Console.ReadLine());

            int lastDigit = num % 10;

           int firstDigit = num;

            while (num >= 10)
            {
                num = num / 10;
            }
            firstDigit = num;

            int sum = 0;
            sum = firstDigit + lastDigit;

            Console.WriteLine("Sum of first and last digit: " + sum);

        }
    }
}
