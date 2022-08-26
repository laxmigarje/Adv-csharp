using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Reverse_List
    {
        static void Main(string[] args)
        {
            
            List<string> lst = new List<string>();

            
            lst.Add("Python");
            lst.Add("C#");
            lst.Add("Java");
            lst.Add("C++");

            Console.WriteLine("Elements Present in List:");

            
            foreach (string i in lst)
            {
                Console.WriteLine(i);
            }

            

           

            
            lst.Reverse();

            
            foreach (string i in lst)
            {
                Console.WriteLine(i);
            }
        }
    }
   
        }
    

