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
            Animal[] animals = new Animal[5];
            animals[0] = new Dog();
            animals[1] = new Pig();
            animals[2] = new Dog();
            animals[3] = new Pig();
            animals[4] = new Dog();

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].makeSound();
            }

        }
    }
    class Pig : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Oinkkk~");
        }
    }
    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Wooff~");
        }
    }
    abstract class Animal
    {
        public abstract void makeSound();
    }
 }

