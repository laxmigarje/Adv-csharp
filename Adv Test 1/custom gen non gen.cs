using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Class2
    {

        class SS<T>
        {
            private T Obj;
            public T obj { get => obj; set => obj = value; }
            
        }
        class S
        {
            private object Obj;
            public  object obj { get => obj; set => obj = value; }
        }
        class Testt
        {
            static void Main(string[] args)
            {
                SS<float> s1 = new SS<float>();
                s1.obj = 4.5f;
                float d = s1.obj;

                S s = new S();
                s.obj = "omkar";
                s.obj = 9000;

                int x = (int)s.obj;
            }
        }
    }
}
