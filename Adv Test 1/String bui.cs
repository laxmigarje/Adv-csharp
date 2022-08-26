using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{

    class String_bui
    { 
    class myStringBuilderSort : IComparer<StringBuilder>
    {
        public int Comparer(StringBuilder x, StringBuilder y);
            
            return x.Tostring().CompareTo(y.Tostring());
    
        
        
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(new StringBuilder("Amit"), 90000);
            sb.Add(new StringBuilder("smit"), 90000);
            sb.Add(new StringBuilder("meet"), 90000);
            sb.Add(new StringBuilder("Amita"), 90000);
            sb.Add(new StringBuilder("siya"), 90000);


            foreach(KeyValuePair<StringBuilder,int>kv in sb)
                Console.WriteLine(kv.Key+"==>"+kv.Value);


            Dictionary<StringBuilder, int> dd = new Dictionary<StringBuilder, int>(sb);


        }
    }
}
