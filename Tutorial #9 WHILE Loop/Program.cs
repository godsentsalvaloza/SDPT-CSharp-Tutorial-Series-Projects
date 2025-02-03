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
            string guessInput, result = "GAME OVER";
            int guess;
            int index = 3;


            while (index > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Random Number Guesser - You have {index} guess left");
                Console.Write("Guess a number betweeen 1 to 5: ");
                guessInput = Console.ReadLine();
                if (int.TryParse(guessInput, out guess))
                {
                    if(guess == 3)
                    {
                        result = "YOU WIN!";
                        break;
                    }else
                    {
                        result = "Wrong Guess. Try Again";
                        index--;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Input");
                    index--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
