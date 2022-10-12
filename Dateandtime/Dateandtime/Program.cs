using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateandtime
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputting the string
            Console.Write("Enter the time in 12 hour format:");
            string time=(Console.ReadLine());
            Console.WriteLine(time);
            string hour=time.Substring(0,2);   
            string rem = time.Substring(2, 6);
            //string min = time.Substring(3,2);
            Console.WriteLine("the sec is:"+min);
            //checking condition for AM
            if (time[8] == 'A' && time[9] == 'M')
            {
                
                if (hour == "12")
                {
                    hour="00";
                    
                }
            }
            //checking condition for PM
            else if (time[8] == 'P' && time[9] == 'M')
            {
                int int2dig=Convert.ToInt32(hour);
                if(int2dig != 12)
                {
                    hour = Convert.ToString(12+int2dig);
                }
            }
            Console.WriteLine(hour+rem);


        }
    }
}
/*
 int int1dig = Convert.ToInt32(hour);
                Console.WriteLine(int1dig);    
                if (min == "60")
                {
                    hour = Convert.ToString(int1dig+ 1);
                } */