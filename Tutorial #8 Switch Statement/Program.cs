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
            string inputDay, inputMonth, inputYear;
            int day, year;
            Console.WriteLine("Date Formatter");

            Console.Write("Enter Day   : ");
            inputDay = Console.ReadLine();
            Console.Write("Enter Month : ");
            inputMonth = Console.ReadLine();
            Console.Write("Enter Year  : ");
            inputYear = Console.ReadLine();

            if(int.TryParse(inputDay, out day) && int.TryParse(inputYear, out year)) {

                if(day <= 31)
                {
                    switch (inputMonth)
                    {
                        case "1":
                        case "01":
                            inputMonth = "January";
                            break;
                        case "2":
                        case "02":
                            inputMonth = "February";
                            break;
                        case "3":
                        case "03":
                            inputMonth = "March";
                            break;
                        case "4":
                        case "04":
                            inputMonth = "April";
                            break;
                        case "5":
                        case "05":
                            inputMonth = "May";
                            break;
                        case "6":
                        case "06":
                            inputMonth = "June";
                            break;
                        case "7":
                        case "07":
                            inputMonth = "July";
                            break;
                        case "8":
                        case "08":
                            inputMonth = "August";
                            break;
                        case "9":
                        case "09":
                            inputMonth = "September";
                            break;
                        case "10":
                            inputMonth = "October";
                            break;
                        case "11":
                            inputMonth = "November";
                            break;
                        case "12":
                            inputMonth = "December";
                            break;
                        default:
                            inputMonth = "ERROR: Invalid Month";
                            break;
                    }
                    Console.WriteLine($"Result: {inputMonth} {day}, {year}");
                }else
                {
                    Console.WriteLine("ERROR: Invalid Day");
                }
            } else
            {
                Console.WriteLine("ERROR: Invalid Input");
            }
        }
    }
}
