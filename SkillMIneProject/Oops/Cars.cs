using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Oops
{
    class Cars
    {
        string name;
        int modelno;
        int price;
        string colour;
       
        static void Main(string[] args)
        {
            Cars C = new Cars();

            C.name = "BMW";
            C.modelno=10;
            C.price=1500000;
            C.colour = " Black";
            Console.WriteLine(C.name + " " + C.modelno + " " + C.price + " " + C.colour + " ");

            Cars C1 = new Cars();

            C1.name = "Swift";
            C1.modelno = 12;
            C1.price = 2100000;
            C1.colour = "White";
            Console.WriteLine(C1.name + " " + C1.modelno + " " + C1.price + " " + C1.colour + " ");

            Cars C2 = new Cars();

            C2.name = "Mercedes";
            C2.modelno=34;
            C2.price = 2000000;
            C2.colour = "Grey";
            Console.WriteLine(C2.name + " " + C2.modelno + " " + C2.price + " " + C2.colour + " ");

        }
    }



}

















