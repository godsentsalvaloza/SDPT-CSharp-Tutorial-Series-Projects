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
            Animal a = new Dog();
            Animal b = new Cat();

            a.MakeSound();
            b.MakeSound();
        }
    }
    class Animal
    {
        virtual public void MakeSound()
        {
            Console.WriteLine("Override this");
        }
    }
    class Dog : Animal
    {
        override
        public void MakeSound()
        {
            Console.WriteLine("Arff");
        }
    }
    class Cat : Animal 
    {
        override
        public void MakeSound()
        {
            Console.WriteLine("Meoww");
        }
    }
 }

