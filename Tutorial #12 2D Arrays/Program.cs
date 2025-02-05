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
            // Multi-dimetional Array
            string[,] accountInfo = { { "Sentry", "sent9x" }, { "Creamy", "Creamy33" }, {"Spike", "spiky" } };
            int index = 1;
            // Using for loop
            //for (int i = 0; i < accountInfo.GetLength(0); i++)
            //{
            //    for(int j = 0; j < accountInfo.GetLength(1); j++)
            //    {
            //        Console.WriteLine(accountInfo[i,j]);
            //    }
            //    Console.WriteLine();    
            //}

            // Using for-each
            foreach (string account in accountInfo)
            {
                Console.WriteLine(account);
                if(index % 2 == 0)
                {
                    Console.WriteLine();
                }
                index++;
            }


        }
    }
}
