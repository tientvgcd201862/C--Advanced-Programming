﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm5
{
    internal class Peerson
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
                this.Salary += this.Salary * percentage / 100;
            else
                this.Salary += this.Salary * percentage / 200;
        }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.Salary is {Salary}";
        }

        internal void Add(Peerson person)
        {
            throw new NotImplementedException();
        }

        public Peerson(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary= salary;
        }

        public Peerson()
        {
        }
      
    }
}

