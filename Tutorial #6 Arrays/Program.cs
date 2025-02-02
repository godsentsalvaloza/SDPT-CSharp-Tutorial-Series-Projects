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
            // Paired Arrays By Index - Challenge
            string[] email = {"creamy@mail.com", "sentry@mail.com", "David@mail.com", "Spike@mail.com", "Alex@mail.com"};
            string[] username = {"Creamy", "Sentry", "David", "Spike", "Alex"};
            string[] password = {"h3eh2d8", "!@^F&^tsdsds", "UHDWH8934y3", "!#*DHheygfe", "2HW&*EG78egd3"};
            int index = 4   ;

            Console.WriteLine("Account Information");
            Console.WriteLine($"Email    : {email[index]}");
            Console.WriteLine($"Username : {username[index]}");
            Console.WriteLine($"Password : {password[index]}");




            // Declear with values
            string[] names = {"Sentry", "Creamy", "Saki"};
            float[] grades = {92.5f, 99.99f, 91.32f};

            // Declear without values
            string[] nicknames = new string[3];
            int[] age = new int[3];

            // displaying array value
            //Console.WriteLine(names[0]);

            // assigning array value
            age[0] = 10;

            // using user input
            //Console.Write("Enter Nickname: ");
            //names[0] = Console.ReadLine();
            //Console.WriteLine($"Hello, {names[0]}");

            //float[] rating = new float[3];
            //Console.Write("Enter Rating: ");
            //rating[0] = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine($"Rating: {rating[0]}");


        }
    }
}
