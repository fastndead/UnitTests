using System;
using System.Globalization;
using System.Threading;

namespace Практикум1010
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            
            Console.Write("ENTER DATE:\nday = ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("month = ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("year = ");
            int year = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nDate by Basic Constructor:");
            _DateTime exampleOfBasicConstructor  = new _DateTime();
            exampleOfBasicConstructor.ShowDate();
            
            Console.WriteLine("\nTyped Date:");
            _DateTime mainDate = new _DateTime(day,month,year);
            
            mainDate.ShowDate();
            
           // mainDate.Data = new DateTime(2018,02,13);
           // mainDate.ShowDate();
            
            Console.Write("\nThe Previous day is\n{0}\nThe next day is\n{1}\n",
                mainDate.GetPreviousDay().ToString("d"),mainDate.GetNextDay().ToString("d"));
            Console.WriteLine("\nThe number of days till the end of the month: " + mainDate.GetDaysTillEndOfMonth());

            if(mainDate.IsLeapYear)
            {Console.WriteLine("\n{0} - is a leap year", mainDate.Data.Year);}
            else
            {Console.WriteLine("\n{0} - is not a leap year", mainDate.Data.Year);}
            
            
            Console.WriteLine(!mainDate ? "\nThis day is NOT the last day of month" :
                                "\nThis day is the last day of month");

            Console.WriteLine(mainDate ? "\nThis is the first day of year" : "\nThis is NOT the first day of year");

            Console.Write("\nENTER DATE TO COMPARE:\nday = ");
            day = int.Parse(Console.ReadLine());
            Console.Write("month = ");
            month = int.Parse(Console.ReadLine());
            Console.Write("year = ");
            year = int.Parse(Console.ReadLine());
            
            _DateTime dateToCompare = new _DateTime(day,month,year);
            
            if (dateToCompare & mainDate)
            {
                Console.WriteLine("\nDates are equal!");
            }
            else
            {
                Console.WriteLine("\nDates are NOT equal");
            }
            
            Console.WriteLine("\nEnter days to add to the date:");
            int daysToAdd = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Result of adding: {0}\n \n ", mainDate[daysToAdd].ToString("d"));
        }
    }
}