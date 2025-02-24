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
            dog d = new dog();
            cat c = new cat();
            bird b = new bird();

            d.makeSound();
            d.walk();
            c.makeSound();
            c.walk();
            b.makeSound();
            b.walk();
            b.fly();
        }
        interface IAnimal
        {
            void makeSound();
        }
        interface ILandAnimal
        {
            void walk();
        }
        interface IAirAnimal : ILandAnimal
        {
            void fly();
        }


        class cat : IAnimal, ILandAnimal
        {
            public void makeSound()
            {
                Console.WriteLine("Meoww~");
            }
            public void walk()
            {
                Console.WriteLine("Cat walking...");
            }
        }
        class dog : IAnimal, ILandAnimal
        {
            public void makeSound()
            {
                Console.WriteLine("Wooff~");
            }
            public void walk()
            {
                Console.WriteLine("Dog walking...");
            }
        }
        class bird : IAnimal, IAirAnimal
        {
            public void makeSound()
            {
                Console.WriteLine("Tweett~");
            }
            public void fly()
            {
                Console.WriteLine("Wooshhh");
            }
            public void walk()
            {
                Console.WriteLine("bird is walking...");
            }

        }

    }
 }

