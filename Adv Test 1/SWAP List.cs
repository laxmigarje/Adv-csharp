using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    public static class swap
    {
        public static void Swap<T>( List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    public class Number
    {
         static void Main(string[]args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            swap.Swap(nums,2, 3);
            Console.WriteLine(nums + " ");  
        }
    
        
          

    }
}
