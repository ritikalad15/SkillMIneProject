using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{

    // average of prime number 
    class Sum10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int avrg = 0;
            bool isprime= true;
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 2; j <= 20; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;

                    }
                    if (isprime)
                    {
                        Console.WriteLine(i);
                        sum = sum + i; 
                        avrg = sum / 10;

                    }
                    isprime = true;

                }
                Console.WriteLine(sum);
                Console.WriteLine(avrg);


            }
        }
    }
}
