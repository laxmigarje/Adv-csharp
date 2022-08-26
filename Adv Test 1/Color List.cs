using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Color_List
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("pink");
            lst.Add("Red");
            lst.Add("Blue");
            lst.Add("Yellow");

            var colors = new List<string> { "Pink", "Red", "Blue", "Yellow" };

            foreach(string color in lst)
            {
                Console.WriteLine(colors + " ");
            }
        }
    }
}
