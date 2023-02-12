using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2_6._2
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Id: ");
            string id = Console.ReadLine();
            System.Console.WriteLine("DoB: ");
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}
