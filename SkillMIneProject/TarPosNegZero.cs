using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class TarPosNegZero
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter the Num");
            num = int.Parse(Console.ReadLine());


            string result = num % 2== 0 ? "Positive" : "Negative";
             Console.WriteLine(result);

        }
    }

    class Divisiblenum
    {
        static void Main(string[] args) 
        {
            int num;
            Console.WriteLine("enter the number to check");
            num = int.Parse(Console.ReadLine());
            string result = (num % 5 == 0 && num % 11 == 0) ? "Num is divisible by 5 &11" : "Num is not Divisible by 5&11";
            Console.WriteLine(result);

        }

    }


    class GreatestOf
    {
        static void Main (string[] args)
        {
            int  num1, num2 , num3;
            Console.WriteLine("enter largest of three...");
            num1 = int.Parse(Console.ReadLine());
            num2= int.Parse(Console.ReadLine());
            num3= int.Parse(Console.ReadLine());
            string result = (num1 > num2) && (num1 > num3) ? "num1 is Largest" : ((num2 > num3) ? "num2 is largest" : "num3 is largest");
            Console.WriteLine(result);
        }
    }
}
