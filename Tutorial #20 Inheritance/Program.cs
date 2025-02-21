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

            BasicEnemy be = new BasicEnemy("Bad", 100, 5);
            be.Attack();
            FlyingEnemy fe = new FlyingEnemy("Fly", 25, 21);
            fe.Attack();


            //Person p = new Person("david", "male", 21);
            //p.IntroduceSelf();

            //Toddler t = new Toddler("creamy", "female", 2, "Cars");
            //t.IntroduceSelf();

            //Child c = new Child("Spike", "Male", 4, "Cars", "Gaming");
            //c.doHobby();
        }

    }
    class Person
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Sex: {sex}");
        }

        public Person(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
    }
    class Toddler : Person
    {
        public string favoriteGame;
        public Toddler(string name, string sex, int age, string favoriteGame) : base(name, sex, age)
        {
            this.favoriteGame = favoriteGame;
        }

        public void Cry()
        {
            Console.WriteLine($"{name} crying");
        }

        public void IntroduceSelf()
        {
            base.IntroduceSelf();
            Console.WriteLine($"Favorite Game: {favoriteGame} ");
        }

    }
    //class Child : Toddler
    //{
    //    public string hobby { get; set; }
    //    public Child(string name, string sex, int age, string favoriteGame, string hobby) : base(name, sex, age, favoriteGame)
    //    {
    //        this.hobby = hobby;
    //    }
    //    public void doHobby()
    //    {
    //        Console.WriteLine($"{name} is doning {hobby}");
    //    }
 }

