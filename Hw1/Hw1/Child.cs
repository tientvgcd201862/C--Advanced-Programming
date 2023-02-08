using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    internal class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if (age > 15)
            {
                System.Console.WriteLine("Children should not have an age more than 15.");
                System.Console.WriteLine("Therefore, the maximum age assigned is 15.");
                Age = 15;
            }
            else
            {
                Age = age;
            }  
        }
        public Child()
        {

        }
        public override string ToString()
        {
            return "Child: " + base.ToString();
        }
    }
}
