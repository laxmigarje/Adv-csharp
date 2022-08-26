using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Ins_Rem_Ele
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            lst.Add("Abhijit");
            lst.Add("Manisha");
            lst.Add("Laxmi");
            lst.Add("Seema");
            lst.Add("Ram");

            lst.Insert(2, "Snehal");

            lst.Remove("Ram");

            foreach(string s in lst)
                Console.WriteLine(s);





        }
    }
}
