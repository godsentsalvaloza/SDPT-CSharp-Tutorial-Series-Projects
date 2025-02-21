using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class FlyingEnemy : Enemy
    {
        int flightSpeed {  get; set; }
        public FlyingEnemy(string name, int health, int flightSpeed) : base(name, health)
        {
            this.flightSpeed = flightSpeed;
        }

        public void Attack()
        {
            base.Attack();
            Console.WriteLine("On the Air");
        }
    }
}
