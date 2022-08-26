using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Student
    {
        static void Main(string[] args)
        {
            var students = new List<string>();
          students.Add("Abhijit");
          students.Add("Manisha");
          students.Add("Seema");

            Console.WriteLine("Our list....");
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }


        }
    }
}
