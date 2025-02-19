using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class User
    {
        // AUTOMATIC PROPERTIES
        //public int UserID { get; set; }
        //public string UserName { get; set; }
        //public string firstName {  get; set; }
        //public string lastName { get; set; }
        //public User(int userID, string userName, string firstName, string lastName)
        //{
        //    this.UserID = userID;
        //    this.lastName = lastName;
        //    this.firstName = firstName;
        //    this.UserName = userName;
        //}

        private int userID;
        private string firstName;
        private string lastName;
        private string userName;

        // properties
        public int UserID
        {
            get { return userID; }
            set
            {
                if (value >= 1000)
                {
                    userID = value;
                }
                else
                {
                    Console.WriteLine("ERROR: The user id must be equal or more than 1,000.");
                }

            }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public User(int userID, string userName, string firstName, string lastName)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
        }
    }
}
