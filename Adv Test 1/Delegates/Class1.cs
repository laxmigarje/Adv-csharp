using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1.Delegates
{
    class Class1
    {
        static double m1(int r , char c)
        {
            return r * 3.4;
        }
        static void m2(byte a , string e)
        {
            Console.WriteLine("in m2"+e+a);
        }

        static bool m3(long m , string s)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, char, double> ff = m1;
            double xx = ff(88, 'a');

            Action< byte, string> aa = m2;
            aa( 144, "Abhijit");

            Func<long, string , bool> f = m3;
            bool bb = f(10, "Yes/No");
        }
    }
}
