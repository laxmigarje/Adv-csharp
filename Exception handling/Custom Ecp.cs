using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception_handling
{
    class Custom_Ecp
    {
        class InvalidExperienceException : ApplicationException
        {

        }


        class Emp : Object
        {
            string nm;
            int experience;

            public string Nm
            {
                set { this.nm = value; }
                get { return nm; }
            }
            public override string ToString()
            {
                return "Name:" + nm + "Experience:" + experience;
            }
            public int Experience
            {
                set
                {
                    if (value < 0)
                        throw new InvalidExperienceException();
                    else
                        this.experience = value;
                }
                get { return experience; }
            }
        }
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Console.WriteLine("Enter name and experience");
            e1.Nm = Console.ReadLine();
            try
            {
                e1.Experience = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Experience cant be negative");

            }
            Console.WriteLine(e1);
        }
    }
}
