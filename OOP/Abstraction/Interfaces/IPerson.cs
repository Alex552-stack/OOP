using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction.Interfaces
{
    internal interface IPerson
    {
        public void setName(string name);
        public string getName();
        public void setAge(int age);
        public uint getAge();
    }
}
