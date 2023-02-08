using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Animal
    {
        string name;
        public string Name { get => name; set => name = value; }
        
        public Animal(string name)
        {
            Name = name;
        }

        public Animal()
        {

        }
        public override string ToString()
        {
            return "animal.";
        }
    }
}
