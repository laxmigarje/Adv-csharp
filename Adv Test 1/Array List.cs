using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Array_List
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            
            number.Add(10);
            number.Add(20);
            number.Add(15);
            number.Add(25);
            number.Add(30);
            number.Add(35);
            number.Add(40);
            number.Add(45);
            
            int[] a = number.ToArray();
            
            Console.WriteLine("the array elements are:");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}
