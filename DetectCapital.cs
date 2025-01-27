using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            bool isFirstCapital = char.IsUpper(word[0]);
            bool areAllCaps = word.Length > 1 && char.IsUpper(word[1]);

            for (int i = 1; i < word.Length; i++)
            {
                // Check consistency based on the case of the first two letters
                if ((areAllCaps && !char.IsUpper(word[i])) ||
                    (!areAllCaps && char.IsUpper(word[i])))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
