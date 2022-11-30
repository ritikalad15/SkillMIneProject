using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Oops
{
    class Student
    {
        int id;
        string name;
        double marks;

        public void AcceptDetails(int sid,string sname,double mk )
        {
            id = sid;
            name = sname;
            marks = mk;

        }

        public void Display()
        {
            Console.WriteLine(id+" "+name + " "+marks);
        }

        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.AcceptDetails(101, "Bidipta", 89.45);
            stud.Display();
        }
            



    }
}
