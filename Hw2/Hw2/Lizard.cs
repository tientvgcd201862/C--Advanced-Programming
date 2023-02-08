using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Lizard : Reptile
    {
        public Lizard()
        {
        }
        public Lizard(string name) : base(name)
        {
            this.Name = "Lizard ";
        }

        public override string ToString()
        {
            return "Lizard is inherited from" + base.ToString();
        }
    }
}
