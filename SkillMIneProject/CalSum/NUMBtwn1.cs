using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CalSum
{
    class NUMBtwn1
    {
        static void Main(string[] args)
        {
            // Calculate the sum of 1 to 10 numbers
            int i, sum = 0;
            Console.WriteLine("sum of 1 to 10 number is....");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);

            }

        }
    }


    class Oddnum
    {
        static void Main(string[] args)
        {
            //Count odd number between 1 to 20
            int i;
            Console.WriteLine("oddnum btwn 1 to 20 are...");
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }


        }
    }

    class evennum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum=" + sum);




        }
    }

    class NUMBTWN
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("oddnum btwn 1 to 20 are...");
            for (i = 120; i >= 81; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
        }

    }

    class Table
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, (num * i));

            }
        }
    }

    class Factor
    {
        static void Main(string[] args)
        {
           int sum=0,i;
            Console.WriteLine("Enter the num ");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num%  i== 0)
                {
                    sum =sum + i;
                    ///Console.WriteLine(i);
                }
                Console.WriteLine("Sum of factor=" + sum);

                   
                    
                
            }
        }
    }
    

    class Divisible
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 50; i++) 
            {
                if ( i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i);

                    }
            }
        }
    }
}  




