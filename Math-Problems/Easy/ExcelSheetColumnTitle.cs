using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Math_Problems.Easy
{
    internal class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {

            StringBuilder stringBuilder = new StringBuilder();
            while (columnNumber>0)
            {
                int reminder = columnNumber % 26;
                if (reminder==0)
                {
                    stringBuilder.Append('Z');
                    columnNumber = (columnNumber/26)-1;
                }
                else
                {
                    stringBuilder.Append((char)((reminder - 1) + 'A'));
                    columnNumber = columnNumber/26; 
                }
            }
            return new string(stringBuilder.ToString().Reverse().ToArray());
        }
    }
}
