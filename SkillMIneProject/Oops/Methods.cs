using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Oops
{
    class Methods
    {

      /*  No Return type No parameter
        public void Done()
        {
            Console.WriteLine("Hello Done method ");
        }
        
          static void Main(string[] args)
          {
            Methods d = new Methods();

            d.Done();
          }*/



        /* No returntype With parameter

       /* public void Addition (int A,float B)
        {
            float ans = A + B;
            Console.WriteLine("Ans=" + ans);
        }

        static void Main(string[] args)
        {
            Methods a= new Methods();
            a.Addition(5432, 5432.1f);
        }*/



        /* With Returntype With Parameter

        public int SumofFactor(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            Methods s  = new Methods();

            int result = s.SumofFactor(2);

            Console.WriteLine("sumofFactor=" + result);
        }*/



        /* With return no parameter
        public int FindCube()
        {
            int num = 45;
            return (num*num*num) ;

        }

        static void Main(string[] args)
        {
            Methods C = new Methods();

            Console.WriteLine("Cube of Number=" + C.FindCube());
        }*/




    }

}


        


            

   
       
 

