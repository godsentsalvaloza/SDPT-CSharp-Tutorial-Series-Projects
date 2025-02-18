using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Character
    {
        public string name, dialog;
        public int hp, mp, lvl;
        public Character(string name, string dialog, int hp, int mp, int lvl)
        {
            this.name = name;
            this.dialog = dialog;
            this.hp = hp;
            this.mp = mp;
            this.lvl = lvl;
        }
        public string Introduce()
        {
            return ($"Hi, I am {name}");
        }
        public string sayDialog()
        {
            return ($"{name} : {dialog}");
        }
        public void checkStats()
        {
            Console.WriteLine($"LEVEL: {lvl}");
            Console.WriteLine($"LEVEL: {hp}");
            Console.WriteLine($"LEVEL: {mp}");
        }
    }
}
