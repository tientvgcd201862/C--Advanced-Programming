using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        public Reptile(string name) : base(name)
        {
            this.Name = "Reptile ";
        }

        public override string ToString()
        {
            return "Reptile, which is inherited from " + base.ToString();
        }
    }
}
