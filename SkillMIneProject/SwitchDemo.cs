using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMIneProject
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            int Daynumber;
            Console.WriteLine("Enter the Daynumber");
            Daynumber = int.Parse(Console.ReadLine());

            switch (Daynumber)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4:Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("sunday");
                    break;
                

            }
           
            
          
            
           
              
           

        

        
        }
    }
}
