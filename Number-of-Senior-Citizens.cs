using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Number_of_Senior_Citizens
    {
        public int CountSeniors(string[] details)
        {
                int count   = 0;
            foreach (string s in details)
            {
                string ageString = $"{s[11]}{s[12]}";
                int age = int.Parse(ageString);
                if (age > 60)
                    count++;
            }
            return count;
        }
    }
}
