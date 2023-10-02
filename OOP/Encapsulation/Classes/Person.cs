﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation.Classes
{
    internal class Person
    {
        private string? Name;
        private uint Age;

        public string? getName()
        { return Name; }
        
        public uint getAge() 
        { return Age;}

        public void setName(string name)
        {
            if(name.Length == 0)
            {
                Console.WriteLine("Empty name");
                return;
            }
            Name = name[0].ToString().ToUpper() + name.Substring(1);
        }
        public void setAge(int age)
        { 
            if(age <= 0)
            {
                Console.WriteLine("Age cannot be negative or 0");
                return;
            }

            Age = Convert.ToUInt32(age);
        }

    }
}
