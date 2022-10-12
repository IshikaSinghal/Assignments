using System;
using System.Net;
using System.Runtime.Remoting.Services;

namespace Timeinword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int hour, mint;
            
            //Inputting hour
            Console.Write("Enter the Hour:");
            hour = (Convert.ToInt32(Console.ReadLine()));

            //Inputting Minute
            Console.Write("Enter the Minute:");
            mint = (Convert.ToInt32(Console.ReadLine()));

            //Checking condition for hour and minute
            if(hour>=1 && hour<=12 && mint>=0 && mint<60)
            {
                //Function Calling
                timeinword(hour, mint);
            }
            else
            {
                Console.WriteLine("Check your input!");
            }
        }
        static void timeinword(int hour,int mint)
        {
            string[] str = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "quarter", "sixteen", "seventeen", "eightteen", "nineteen", "twenty", "twentyone", "twentytwo", "twentythree", "twentyfour", "twentyfive", "twentysix", "twentyeight", "twentynine", "half" };
            //Exception case
            if (mint == 00)
            {
                Console.WriteLine("{0}o'clock", hour);
            }
            //Checking condition for mint under 1 to 30
            else if (mint >= 1 && mint <= 30)
            {
                Console.WriteLine("{0} minute past {1}", str[mint-1], str[hour-1]);
            }
            //Checking condition for mint greater than  30 to under 59
            else if (mint > 30 && mint <= 59 && mint!=45)
            {
                mint = 60 - mint;
                Console.WriteLine("{0} minute to {1}", str[mint-1], str[hour]);
            }
            //Checking condition for 45 minute
            else if (mint == 45)
            {
                mint = 60 - mint;
                Console.WriteLine("quarter to {1}", str[mint - 1], str[hour]);
            }
            Console.ReadLine();
        }
       
    }
}
/*
 
 */
