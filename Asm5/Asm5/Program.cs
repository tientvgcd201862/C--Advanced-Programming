using System;
using System.Collections.Generic;
using System.Linq;

namespace Asm5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of person: ");
            var lines = int.Parse(Console.ReadLine());
            var people = new List<Peerson>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                Console.WriteLine("first name: ");
                var FirstName = Console.ReadLine();
                Console.WriteLine("last name: ");
                var LastName = Console.ReadLine();
                Console.WriteLine("age: ");
                var Age = int.Parse(Console.ReadLine());
                Console.WriteLine("salary: ");
                var Salary = int.Parse(Console.ReadLine());
                Peerson person = new Peerson(FirstName, LastName, Age, Salary);
                people.Add(person);
                Console.WriteLine(person.ToString());
                Console.ReadLine();
                

                // Create variables for constructor parameters
                // Initialize a Person
                // Add it to the list

            }
            Console.WriteLine("sorted by name and age");
            var sorted = people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, sorted));


        }
    }
}
