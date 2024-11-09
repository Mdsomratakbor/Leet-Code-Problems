using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Valid_Word
    {
        public bool IsValid(string word)
        {

            int atLeastOneVowel = 0,
                atLeastOneConsonant = 0;

            if (word.Length < 3)
            {
              return  false;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char character = char.ToLower(word[i]);      
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }

                if ("aeiou".Contains(character))
                {
                    atLeastOneVowel++;
                }
                else if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
                {
                    atLeastOneConsonant++; 
                }

            }
            return atLeastOneVowel > 0 && atLeastOneConsonant > 0;
        }
    }
}
