using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class Capital
    {
        static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("enter the Charcter");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A')
            {
                Console.WriteLine("vowel");
            } 
            else if (ch == 'E')
            {
                Console.WriteLine("Vowel");

            }
            else if (ch == 'I')
            {
                Console.WriteLine("Vowel");

            }
            else if (ch == 'O')
            {
                Console.WriteLine("Vowel");

            }
            else if (ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");

            }
        }   
    }
}
