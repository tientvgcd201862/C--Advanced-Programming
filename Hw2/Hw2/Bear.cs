using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Bear : Mammal
    {
        public Bear()
        {
        }
        public Bear(string name) : base(name)
        {
            this.Name = "Bear ";
        }

        public override string ToString()
        {
            return "Bear is inherited from " + base.ToString();
        }
    }
}
