using System;
using System.Collections.Generic;

namespace Asm6
{

    internal class Program
    {
       
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }
        public class Dog:Animal
        {
            public void Bark()
            {
                Console.WriteLine("Braking");
            }
        }

        public class Puppy:Animal
        {
            public void Bark() { }
            public void Weep()
            {
                Console.WriteLine("weeping");
            }
        }
        public class Cat:Animal
        {
            public void Bark() { }
            public void Weep() { }
            public void Eat() { }
            public void Meow() {
                Console.WriteLine("meowing...");
            }
        }
        

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            dog.Bark();
            Console.WriteLine("..........");
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Console.WriteLine("..........");
            Dog dog1 = new Dog();
            dog1.Eat();
            dog1.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
