using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    internal class Zigzag_Conversion
    {
        public string Convert(string s, int numRows)
        {

            if (numRows == 1 || s.Length <= numRows)
                return s;

            List<StringBuilder> rows = new List<StringBuilder>();

            for (int i = 0; i < numRows; i++)
            {
                rows.Add(new StringBuilder());
            }

            int currRow = 0;
            bool goingDown = false;


            foreach (char c in s)
            {
                rows[currRow].Append(c);

                if (currRow == 0 || currRow == numRows - 1)
                    goingDown = !goingDown;

                currRow += goingDown ? 1 : -1;
            }
            StringBuilder result = new StringBuilder();

            foreach (StringBuilder row in rows)
                result.Append(row);

            return result.ToString();
        }


    }
}
