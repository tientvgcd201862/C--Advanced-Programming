using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Gorilla : Mammal
    {
        public Gorilla()
        {
        }
        public Gorilla(string name) : base(name)
        {
            this.Name = "Gorilla ";
        }

        public override string ToString()
        {
            return "Gorilla is inherited from " + base.ToString();
        }
    }
}
