using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Dict_Keys
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            
            d.Add(1, "Manisha");
            d.Add(2, "Abhijit");
            d.Add(3, "Seema");
            d.Add(4, "Beba");
            
            
            List<int> keys = new List<int>(d.Keys);
            Console.WriteLine("Displaying keys...");
            foreach (int i in keys)
            {
                Console.WriteLine(i);
            }
        }
    }
}
    

