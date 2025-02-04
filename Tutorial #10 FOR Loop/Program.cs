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
            string[] userName = {"Sentry", "Creamy", "Spike" };
            string[] password = {"sentry123", "Creamy123", "Spiky33" };
            string nameInput, passwordInupt, result = "ERROR: Account not Found";

            Console.WriteLine("Please Authenticate");
            Console.Write("Username : ");
            nameInput = Console.ReadLine();
            Console.Write("Password : ");
            passwordInupt = Console.ReadLine();

            for (int x = 0; x < userName.Length; x++)
            {
                if (userName[x].Equals(nameInput) && password[x].Equals(passwordInupt))
                {
                    result = $"WELCOME: {userName[x]}";
                    break;
                }
                else if (userName[x].Equals(nameInput) && !password[x].Equals(passwordInupt))
                {
                    result = $"ERROR: Wrong password for {userName[x]}";
                    break;
                }
                else
                {
                    result = $"ERROR: Account not Found";
                }
            }
            Console.WriteLine(result);


        }
    }
}
