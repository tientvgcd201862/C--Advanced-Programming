using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dicel = new Dice();
            dicel.Side = 5;
            Console.WriteLine($"the number of side: " + dicel.Side);
            Console.WriteLine("the result of running the dice: " + dicel.Roll());
            Console.ReadLine();
        }
    }
}
