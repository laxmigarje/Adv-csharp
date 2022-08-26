using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Multiple_Catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter Number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division":a / b);
                Console.WriteLine("try ends");
            }
            catch (DividedByZeroException)
            {
                Console.WriteLine(1);
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(2);
                Console.WriteLine(e.Message);
                    
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
               e1.Experience int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Experience cany be negative");
                Console.WriteLine(e1);
            }
        }
    }
}
