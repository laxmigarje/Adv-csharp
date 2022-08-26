using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Dictionary
{
    class Class2
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>()
            { "red", "pink", "blue", "red","pink", "yellow", "red"};

            string s = "pratiksha";
            char[] carr = s.ToCharArray();
            //key_color
            //value is count
            Dictionary<string, int> dd = new Dictionary<string, int>();
            //["red"=1,"pink"=1,"blue"=1]
            foreach(string color in ll)
            {
                if(dd.ContainsKey(color))
                {
                    int oldvalue = dd[color];
                    dd[color] = oldvalue + 1;

                }
                else
                {
                    dd.Add(color, 1);
                }
            }
        }
    }
}
