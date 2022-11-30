using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class Sum6
    {
        // to check number is trimorphic or not 
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int result = num * num * num ;
           int firstD  = result % 10;
            Console.WriteLine(firstD);
            int lastD = num % 10;
            Console.WriteLine(lastD);
            if (firstD == lastD)
            {
                Console.WriteLine("num is Trimorphic"); 

            }
            else
            {
                Console.WriteLine("num is not Trimorphic");
            }
        }
    }
}
