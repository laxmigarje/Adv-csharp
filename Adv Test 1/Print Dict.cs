using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    class Print_Dict
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict =
          new Dictionary<string, string>();

            
            myDict.Add("Math", "Science");
            myDict.Add("Eng", "History");
            myDict.Add("Hindi", "Telgu");
            myDict.Add("Marathi", "Geography");
            
             Console.WriteLine("Total key/value pairs in" +
                        " myDict are : " + myDict.Count);

            
            
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                Console.WriteLine(kvp.Key, kvp.Value);
            }
        }
    
        }
    }

