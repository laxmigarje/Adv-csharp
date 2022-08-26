using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Dictionary
{
    class Emp
    {
        
        static void Main(string[] args)
        {
            List<Emp> ll = new List<Emp>();
           // ll.Add(new Emp("Deepa", 8));
           // ll.Add(new Emp("sapana", 9));

            //keys should be unique

            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("abhijit",94);
            dd.Add("manisha", 90);
            dd.Add("seema", 90);
            dd.Add("beba", 91);

            Console.WriteLine(dd["abhijit"]);
            dd["manisha"] = 94;


        }
    }
}
