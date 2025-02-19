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
            User u = new User(2001, "SDPTdavid", "David", "SDPT");

            //// SET
            //u.UserID = 1001;

            //// GET
            //Console.WriteLine(u.UserID);
        }
    }
}
