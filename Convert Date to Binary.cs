using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Convert_Date_to_Binary
    {
        public string ConvertDateToBinary(string date)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int[] stringArray = date.Split('-').Select(int.Parse).ToArray();

            stringBuilder.Append(Convert.ToString(stringArray[0], 2));
            stringBuilder.Append("-");
            stringBuilder.Append(Convert.ToString(stringArray[1], 2));
            stringBuilder.Append("-");
            stringBuilder.Append(Convert.ToString(stringArray[2], 2));
            return stringBuilder.ToString();    
        }
    }
}
