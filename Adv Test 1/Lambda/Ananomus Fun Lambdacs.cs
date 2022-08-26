using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1.Lambda
{
    class Ananomus_Fun_Lambdacs
    {
        public delegate void mydel7(int a, int b);
        public delegate int mydel8(int a);

        static void Main(string[] args)
        {
            //anonymous function
            mydel7 d = delegate (int a, int b)

             {
                 Console.WriteLine("product=" + (a*b));
             };
            d(9, 7);

            //Lambda
            mydel7 d2 = (a, b) => Console.WriteLine("Area of rect=" +(a*b));

            d2(11, 12);
            mydel8 ddd = (a) =>
            {
                return a * a;
            };
            int sq = ddd(6);

            mydel8 ddd2 = (a) => a * a;

            int sqq = ddd2(9);
            Console.WriteLine("Square="+sqq);


        }
    }
}
