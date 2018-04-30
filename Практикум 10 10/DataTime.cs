using System;
using System.Runtime.CompilerServices;


namespace Практикум1010
{
    public class _DateTime
    {
        private DateTime data;

        public _DateTime()
        {
            data = new DateTime(2010,1,1);
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        

        public bool IsLeapYear
        {
            get { return DateTime.IsLeapYear(data.Year); }
        }
        public _DateTime(int day, int month, int year)
        {
            data = new DateTime(year,month,day);
        }

        public _DateTime(DateTime date):this(date.Day,date.Month,date.Year)
        { }

        public void ShowDate()
        {
            Console.WriteLine(data.ToString("d"));
        }

        public DateTime GetPreviousDay()
        {
            return data.AddDays(-1);
        }

        public DateTime GetNextDay()
        {
            return data.AddDays(1);
        }

        public int GetDaysTillEndOfMonth()
        {
            return int.Parse(DateTime.DaysInMonth(data.Year,data.Month).ToString())
                   - int.Parse(data.Day.ToString());
        }
        
        public DateTime this[int i]
        {
            get { return data.AddDays(i); }
        }

        public static bool operator !(_DateTime data)
        {
            if (data.Data.Day == DateTime.DaysInMonth(data.Data.Year, data.Data.Month))
            {
                return false;
            }

            return true;
        }

        public static bool operator true(_DateTime data)
        {
            return data.Data.Day == 1 && data.Data.Month == 1;
        }

        public static bool operator false(_DateTime data)
        {
            return data.Data.Day != 1 && data.Data.Month != 1;
        }

        public static bool operator &(_DateTime data, _DateTime data1)
        {
            return data.Data == data1.Data;
        }
        
    }
}