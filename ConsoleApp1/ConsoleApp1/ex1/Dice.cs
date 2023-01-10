using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ex1
{
    internal class Dice
    {
        private int side;

        public int Side
        {
            set { if (value > 0) side = value; }
            get { return side; }
        }

        public void SetSide(int side)
        {
            if (side > 0)
            {
                this.side = side;
            }
            else
            {
                side = 6;
            }
        }

        public int Roll()
        {
            Random rd = new Random();
            return rd.Next(1, side + 1);
        }
    }
}
