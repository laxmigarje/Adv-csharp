using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Replace_Ele
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(100);
            l.Add(200);
            l.Add(300);
            l.Add(400);
            l.Add(500);

            for (int i = 0; i < l.Count; i++)
            {
                if (l.Contains(200))
                    l[i] = (500);
            }
        }
    }
}

