using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Adv_Test_1
{
    
    
        class Empp
    {
        int eno;
        string name;
        string deptname;

        public Empp(int eno,string name,string deptname)
        {
            this.Eno=eno;
            this.Name = name;
            this.Deptname = deptname;
        }
        public override string ToString()
        {
            return "Eno:" + eno + "Name:" + name + "Departmentname=" + deptname;
        }

        public int Eno{ get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Deptname { get => deptname; set => deptname = value; }
        }
    }

