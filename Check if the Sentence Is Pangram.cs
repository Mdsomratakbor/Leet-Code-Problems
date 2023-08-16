using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Check_if_the_Sentence_Is_Pangram
    {
        public bool CheckIfPangram(string sentence)
        {
            Dictionary<char, bool> result = new Dictionary<char, bool>();
            for(int i=0; i < 26; i++)
            {
                result.Add((char)('a' + i), false);
            }
           
                for (int i=0; i<sentence.Length; i++)
            {
                if (result.ContainsKey(sentence[i]))
                    result[sentence[i]] = true;
            }

            foreach (var c in result)
            {
                if(c.Value ==false)
                    return false;
            }
            return true;
        }
    }
}
