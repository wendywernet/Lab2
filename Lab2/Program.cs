using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime firstdate=new DateTime();
            bool flag1 = true;
           
            //while loops to ensure user enters correct date formats
            while (flag1)
            {

                Console.WriteLine("Enter any date in MM/dd/yyyy format:");
                string Date = Console.ReadLine();
                if (!DateTime.TryParseExact(Date, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out firstdate))
                {

                    Console.WriteLine("This is an invalid entry. Please enter in MM/dd/yyyy format");
                    flag1 = true;
                }
                else
                {
                    flag1 = false;
                    

                }
            }
            DateTime seconddate=new DateTime();
            bool flag2 = true;


            while (flag2)
            {
                Console.WriteLine("Enter another date in MM/dd/yyyy format:");
                string Date = Console.ReadLine();
                if (!DateTime.TryParseExact(Date, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out seconddate))
                {
                    Console.WriteLine("This is an invalid entry. Please enter in MM/dd/yyyy format");
                    flag2 = true;
                }
                else
                {
                    flag2 = false;
                }
            }
            //Calculate difference between firstdate and secondate and formulate hours, days, and minutes.
            TimeSpan difference=(firstdate-seconddate);
            var days = Math.Abs(difference.Days);
            var hours = Math.Abs(difference.Days * 24);
            var minutes = Math.Abs(difference.Days * 1440);

            Console.WriteLine("The time difference between the dates are " + days + " day(s), " + hours + " hours, or " + minutes + " minutes.");
            Console.ReadLine();















        }
    }    
}
