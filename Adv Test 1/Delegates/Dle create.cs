using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1.Delegates
{

    class Dle_create
    {
        public delegate void mydele();
        class proram
        {
            public delegate int mydel2(int a, int b);

            public static int Add(int a, int b)
            {
                Console.WriteLine("Add+" + (a + b));

                return a + b;
            }

            static void greet()
            {
                Console.WriteLine("Good Evening");
            }
            static void Main(string[] args)
            {
                mydele d1 = greet;
                d1();

                mydele2 d2 = Add;
                int r = d2(10, 20);
            }

        }
    }

    class overload
    {
        public delegate void myde13(int a);

        public static void m1(int a)
        {
            Console.WriteLine("in m1" + a);
        }
        public static void square(int n)
        {
            Console.WriteLine("square" + n * n);
        }
        static void Main(string[] args)
        {
            //single cast
            mydel3 d1 = square;

            //multicast
            mydel3 d2 = square;
            d2 = d2 + m1;
            d2(9);

        }
        public static void m1(int a, int b)
        {
            Console.WriteLine("in m1" + a + " " + b);
        }
    }
}
       

    

