using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string columnTitle)
        {
            int number = 0;

            for (int i = 0; i < columnTitle.Length; i++)
                number = (columnTitle[i] - 'A' + 1) + (26 * number);

            return number;
        }
    }
}
