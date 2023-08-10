using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Number_of_Days_Between_Two_Dates
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            DateTime firstDate = Convert.ToDateTime(date1);
            DateTime secondDate = Convert.ToDateTime(date2);
            return Math.Abs((secondDate - firstDate).Days);
        }
    }
}
