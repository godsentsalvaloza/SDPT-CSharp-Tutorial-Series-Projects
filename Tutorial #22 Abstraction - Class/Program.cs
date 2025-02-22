using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog("Creamy", 4);
            Animal c = new Cat("Opal", 3);


        }
        abstract class Animal
        {
            string name {  get; set; }
            int age { get; set; }
            public Animal(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public abstract void makeSound();
        }
        class Dog : Animal
        {
            public Dog(string name, int age) : base(name, age)
            {

            }
            public override void makeSound()
            {
                Console.WriteLine("Wooff");
            }
        }
        class Cat : Animal
        {
            public Cat(string name, int age) : base(name, age)
            {
            }

            public override void makeSound()
            {
                Console.WriteLine("Meoww");
            }
        }
    }
 }

