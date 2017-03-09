using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeLab dt = new DateTimeLab();          
            Console.WriteLine(dt.GetDateToday());
            
            Console.WriteLine("-------------------------------------------------");

            var u = dt.GetStringFromParameters(2017, 2, 11);
            Console.WriteLine(u);
            Console.ReadLine();
        }

       
    }

    public class DateTimeLab
    {
        public DateTime GetDateToday()
        {
            //returns a datatime object that is set to the current day's date
            DateTime Today = DateTime.Now.Date;
            return Today;        
        }

        public string GetStringFromParameters(int month, int day, int year)
        {
            //return a string that represents the date for the month day and year passed to the method parameters as integer.
            //expected return value should be in format "12/25/15
            DateTime theDateRequested = new DateTime(year, month, day);
            return theDateRequested.ToString("M/d/yy");
        }
    }
}
