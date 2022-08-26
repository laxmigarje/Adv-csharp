using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception_handling
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter number");

            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division:"+a/b);
                Console.WriteLine("Try ends");
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);

            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for(int i=1;i<=10;i+=2)
            {
                Console.WriteLine(i);
            }

        }
    }
}

