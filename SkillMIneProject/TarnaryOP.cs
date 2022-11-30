using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class TarnaryOP
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());

            string result = num % 2 == 0 ? "even" : "odd";
            Console.WriteLine(result);

        }
    }
}
