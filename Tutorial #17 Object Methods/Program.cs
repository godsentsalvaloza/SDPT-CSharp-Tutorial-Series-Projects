using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Character c = new Character("Creamy", "Woof-woof", 12, 2,1);
            //Console.WriteLine(c.Introduce());


            Student s1 = new Student("Sentry", "Malaguena", "Arleigh", "STEM", 2, 94, 96);
            s1.IntroduceSelf();
            s1.evaluateGrade();
        }
    }
}
