using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortList
{
    class Sorted_Demo
    {

        static void Main(string[] args)
        {
            SortedList<Employee, string> s = new SortedList<Employee, string>();
            s.Add(new Employee(111, "Kamal", "CS"), "java");
            s.Add(new Employee(112, "Ashwini", "IT"), "C++");
            s.Add(new Employee(113, "Gauri", "Sci"), "Python");
            s.Add(new Employee(114, "Zahir", "Engi"), "java");
            s.Add(new Employee(115, "Asha", "CS"), "C");
            foreach (KeyValuePair<Employee, string> kv in s)
            {
                Console.WriteLine(kv.Key + "\t==>" + kv.Value);
            }
            SortedList<Employee, string> ss = new SortedList<Employee, string>();
            ss.Add(new Employee(1, "ASDF", "Mach"), "JS");
        }

        class Employee : IComparable<Employee>
        {
            public string name;
            public string dept;
            public int eno;
            public Employee(int eno, string name, string dept)
            {
                this.eno = eno;
                this.name = name;
                this.dept = dept;
            }
            public int CompareTo(Employee other)
            {
                return this.name.CompareTo(other.name);
            }
            public override string ToString()
            {
                return ("\tEno:" + "\tName:" + name + "\tDepartment:" + "dept");
            }
        }






    }
}

