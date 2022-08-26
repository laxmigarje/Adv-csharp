using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortList
{
    class Employee_sort
    {
       
        
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
       
        

        
        
            
        



    



