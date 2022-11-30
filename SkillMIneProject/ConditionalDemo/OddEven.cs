using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject.ConditionalDemo
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");

            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");

            }
        }

    }

    class Divisible
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter value ");

            num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Num is Divisible by 5");

            }
            else
            {
                Console.WriteLine("Num is not Divisible by 5");

            }



        }

    }

    class posNegZero
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Value");

            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("num is Positive");


            }
            else if (num < 0)
            {
                Console.WriteLine("num is Negative");

            }
            else
            {
                Console.WriteLine("num is Zero");

            }
        }

    }

    class Divisibleby
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter num divisible by 3 & 9");

            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine(" Divisible by 3");

            }
            else if (num % 9 == 0)
            {
                Console.WriteLine("Divisible by 9");

            }
            else
            {
                Console.WriteLine("Num is not Divisible");



            }


        }

    }


    class DayName
    {
        static void Main(string[] args)
        {
            int Day;

            Console.WriteLine("Enter Week num (1 to 7)");

            Day=int.Parse(Console.ReadLine());
            if (Day == 1)
            {
                Console.WriteLine("Monday");

            }
            else if (Day == 2)
            {
                Console.WriteLine("Tuesday");

            }
            else if (Day == 3)
            {
                Console.WriteLine("Wednesday");

            }
            else if (Day == 4) 
            {
                Console.WriteLine("Thursday");
            }
            else if (Day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (Day == 6)
            {
                Console.WriteLine("Saturday");
        
            
            }
            else if (Day == 7)
            {
                Console.WriteLine("Sunday");

            }
            else
            {
                Console.WriteLine(" Invalid Number,Enter num (1 to 7 )");

            }


        }

    }
}
