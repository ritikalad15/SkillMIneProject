using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class Triangle
    {
        static void Main(string[]args)
        {
            int Base, Height;

            Console.WriteLine("enter the value for base");

            Base = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the value for height");

            Height = int.Parse(Console.ReadLine());

            Console.WriteLine(0.5 * Base * Height);
             
            

        }
    }
}
