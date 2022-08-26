using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1.Lambda
{
    public delegate int mydel1(int n);
    class Factorial
    {
        static void Main(string[] args)
        {
            mydel1 a = (n) =>
            {
                int i, f = 1;
                for (i = 1; i <= n; i++)
                {
                    f = f * i;
                }
                return f;
            };
            int e = a(7);
            Console.WriteLine(e);
        }
    }
}
