using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && year % 100 != 0||(year % 400 == 0))
            {
                
                
                    Console.WriteLine(year + "year is leap year ");

                

            }
            else
            {
                Console.WriteLine(year + "year is not leap year ");

            }
        }
    }
}
