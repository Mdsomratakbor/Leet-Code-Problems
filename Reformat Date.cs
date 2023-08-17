using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reformat_Date
    {

        /// <summary>
        /// Need to optimize this problem because, this problem time complixit too much. beat only 18%
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public string ReformatDate(string date)
        {
            string[] dateArray = date.Split(' ');


            return $"{dateArray[2]}-{ConvertMonthDigit(dateArray[1])}-{ConvertDay(dateArray[0])}";
        }

        private string ConvertMonthDigit(string MM)
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            return (Array.IndexOf(months,MM)+1).ToString("D2");
        }
        private string ConvertDay(string day)
        {
            string[] ordinalNumbers = { "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th",
                                    "11th", "12th", "13th", "14th", "15th", "16th", "17th", "18th", "19th", "20th",
                                    "21st", "22nd", "23rd", "24th", "25th", "26th", "27th", "28th", "29th", "30th", "31st" };
            return (Array.IndexOf(ordinalNumbers, day)+1).ToString("D2");
        }
    }
}
