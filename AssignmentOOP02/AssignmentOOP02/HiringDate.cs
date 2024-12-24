using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AssignmentOOP02
{


    #region Solution Q2
    //2.Develop a Class to represent the Hiring Date Data:
    //⮚	consisting of fields to hold the day, month and Years.

    internal class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentException("Day must be between 1 and 31.");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Month must be between 1 and 12.");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Year must be between 1900 and the current year.");
                year = value;
            }
        }

        public string GetFormattedDate()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
    #endregion
}
