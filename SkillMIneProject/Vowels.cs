using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class Vowels
    {
        static void Main(string[] arg)
        {
            char ch;
            Console.WriteLine("Enter the Char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'u')
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
