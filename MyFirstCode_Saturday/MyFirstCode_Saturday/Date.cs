using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace MyFirstCode_Saturday
{
    public class Date
    {
        #region
        private int _year;
        private int _month; 
        private int _day;
        #endregion

        #region Methods
        public Date()
        {
                
        }
        public Date(int year, int month, int day)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day,month, year);
        }
        private bool IsLeapYear(int year)
        {
            bool isLeap = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
            return isLeap;
        }
        private int ValidateDay(int day, int month, int year)
        {
            int[] vdaysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            if (day >= 1 && day <= vdaysPerMonth[month])
            {
                return day;
            }

            throw new DayException("The day is invalid!.");
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new YearException("The year is invalid!.");
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <=12)
            {
                return month;
            }
            throw new MonthException("The month is invalid!.");
        }

        public override string ToString()
        {
            string date = $"{_year}/{_month}/{_day}";
            return date;
        }

        #endregion


    }
}
