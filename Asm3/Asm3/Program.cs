using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();
            Console.WriteLine("Choose the function below");
            function.Menu();
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            do
            {
                if (choice == 1)
                {
                    function.AddAStudentToList();
                }
                else if (choice == 2)
                {
                    Console.Write("Enter student name: ");
                    string studentName = Console.ReadLine();
                    
                    function.FindByName(studentName);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("End the program!");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please try again!");
                }
                function.Menu();
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            while (true);
            Console.ReadLine();
        }
    }
}
