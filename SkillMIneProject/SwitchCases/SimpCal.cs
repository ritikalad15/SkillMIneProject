using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.SwitchCases
{
    class SimpCal
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter an operand (+, -, /, *): ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine("Addition" + (num1 + num2));
                    break;
                case '-': Console.WriteLine("Substraction" + (num1 - num2));
                    break;
                case '/': Console.WriteLine("Division" + (num1 / num2));
                    break;
                case '*': Console.WriteLine("Multiplication" + (num1 * num2));
                    break;

            }

        }
    }


    class Vowel
    {
        static void Main(string[] args)
        {

            char ch;
            {
                Console.WriteLine("Enter the ch");
                ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case 'a': Console.WriteLine("vowel");
                        break;
                    case 'e': Console.WriteLine("vowel");
                        break;
                    case 'i': Console.WriteLine("Vowel");
                        break;
                    case 'o': Console.WriteLine("Vowel");
                        break;
                    case 'u': Console.WriteLine("vowel");
                        break;
                    default: Console.WriteLine("Consonent");
                        break;


                }


            }
        }
    }
    class OddEven
    {
       static void Main (string[] args)
        {
            int num;
            Console.WriteLine("enter the num");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:Console.WriteLine("Num is odd");
                    break;

                case 2: Console.WriteLine("Num is even");
                    break;
                
            }
        }

    }
    
        
 
        
}
