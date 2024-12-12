using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_if_All_Characters_Have_Equal_Number_of_Occurrences
    {
        public bool AreOccurrencesEqual(string s)
        {
            int firstLetterCount  = 0;
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (keyValuePairs.ContainsKey(c))
                    keyValuePairs[c] = keyValuePairs[c] + 1;
                else keyValuePairs[c] = 1;
            }

            firstLetterCount = keyValuePairs.First().Value;
            return !keyValuePairs.Any(x => x.Value != firstLetterCount);
        }
    }
}
