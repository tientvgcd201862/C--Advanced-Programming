using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    internal class Person
    {
        string name;
        int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


        public Person(string name, int age)
        {
            Name = name;
            if (age <= 0)
            {
                System.Console.WriteLine("Age cannot negative ");
                System.Console.WriteLine("Therefore, the minimum age assigned is 0");
                Age = 0;
            }
            else
            {
                Age = age;
            }
        }
        public Person()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + "; Age: " + Age;
        }

        // 1. Add Fields
        // 2. Add Constructor
        // 3. Add Properties
        // 4. Add Methods
    }
}
