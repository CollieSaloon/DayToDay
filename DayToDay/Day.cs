using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToDay
{
    class Day
    {
        private List<Activity> activities;
        public string dayName { get; private set; }
        public int dayNum { get; private set; }
        public string month { get; private set; }
        public int year { get; private set; }

        public Day(List<Activity> list, DateTime date)
        {
            activities = list;
            dayName = date.DayOfWeek.ToString();
            dayNum = date.Day;
            month = GetMonthName(date.Month);
            year = date.Year;

        }

        private string GetMonthName(int monthNum)
        {
            string name = "";

            switch (monthNum)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    break;
            }

            return name;
        }

        
    }
}
