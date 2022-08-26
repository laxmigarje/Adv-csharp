using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception_handling
{
    class Null
    {
        static string nm;

        static void Main(string[] args)
        {
            Console.WriteLine("enter age");

            try
            {
                Console.WriteLine("enter age");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Try ends");
        }
    }
}
