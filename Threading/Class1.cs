using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1.Threading
{
    class Class1
    {
        //Thread
        //Single thread enviourment

        static void m1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            Class1 ob = new Class1();
            Thread t1 = new Thread( m1);
            //t1.start();
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine("GM");
            }
            Console.WriteLine("Main ends");
        }
    }
}
