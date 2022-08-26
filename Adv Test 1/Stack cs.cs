using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Stack_cs
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();

            st.Push("Raj");
            st.Push("Abhi");
            st.Push("Ram");
            st.Push("veena");

            string dataRemove = st.Pop();

            string dataPeek = st.Peek();

            Console.WriteLine("Peek" + dataPeek);

            foreach(string d in st)
                Console.WriteLine(d);
        }
    }
}
