using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Dict_Value
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "Manisha");
            d.Add(2, "Abhijit");
            d.Add(3, "Seema");
            d.Add(4, "Beba");


            Dictionary<int, string>.ValueCollection value = d.Values;
           
            foreach (string s in value)
            {
                Console.WriteLine(s);
            }
        }
    }
}
