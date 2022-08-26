using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Collection
{
    class Linked_List
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);
            ll.AddLast(200);

            LinkedListNode<int> nn = ll.Find(200);
            ll.AddBefore(nn, 1000);

            ll.AddAfter(nn, 2000);

            //ll.clear();
            Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Contains(34));
            //int x = ll.First();
           // int last = ll.Last();


            ll.Remove(90);

            foreach(int d in ll)
                Console.WriteLine(d);
        }
    }
}
