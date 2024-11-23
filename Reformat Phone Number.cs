using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reformat_Phone_Number
    {
        public string ReformatNumber(string number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int length = 0;
            foreach (char c in number)
            {
                if (char.IsDigit(c))
                {
                    stringBuilder.Append(c);
                    length++;
                }
             

            }
            int index = 3;
            while (length>4)
            {
                if (length > 4)
                {
                    stringBuilder.Insert(index, '-');
                    index += 4;
                    length -= 3;
                }
          
            }
            if (length == 4)
            {
                stringBuilder.Insert(index - 1, '-');
            }

            return stringBuilder.ToString();
        }
    }
}
