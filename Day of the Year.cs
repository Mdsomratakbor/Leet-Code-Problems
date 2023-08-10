using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Day_of_the_Year
    {
        public int DayOfYear(string date)
        {
            DateTime givenDate = Convert.ToDateTime(date);
            int year = givenDate.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            return (givenDate - firstDay).Days+1;
        }
    }
}
