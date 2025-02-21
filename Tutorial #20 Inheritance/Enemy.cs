using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Enemy
    {
        public Enemy(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public string name { get; set; }
        public int health { get; set; }
        public void Attack()
        {
            Console.Write("Attacking...");
        }
    }
}
