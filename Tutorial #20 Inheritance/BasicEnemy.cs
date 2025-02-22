using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class BasicEnemy : Enemy
    {
        public int walkSpeed { get; set; }
        public BasicEnemy(string name, int health, int speed) : base(name, health)
        {
            this.walkSpeed = speed;
        }

        public void Attack()
        {
            base.Attack();
            Console.WriteLine("On the ground");
        }
    }
}
