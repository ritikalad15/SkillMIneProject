using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class Percentage
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            Console.WriteLine("Enter 5 Marks");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            float per = ((num1 + num2 + num3 + num4 + num5) * 100) / 500;
            if (per > 70)
            {
                Console.WriteLine(per + "Grade is Distinction");

            }
            else if (per >= 60 && per <= 70)
            {
                Console.WriteLine(per + "Grade is First Class");

            }
            else if (per >= 50 && per <= 60)
            {
                Console.WriteLine(per + "Grade is Second class");

            }
            else if (per >= 35 && per <= 50)
            {
                Console.WriteLine(per + "Grade is Pass class");

            }
            else if (per < 35)
            {
                Console.WriteLine(per + "Fail");

            }
            else
            {
                Console.WriteLine("no Grade");

            }

        }
    }
}
