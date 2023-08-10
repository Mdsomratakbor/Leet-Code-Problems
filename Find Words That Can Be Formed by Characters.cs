using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Find_Words_That_Can_Be_Formed_by_Characters
    {
        public int CountCharacters(string[] words, string chars)
        {
            int sum = 0;
            foreach (string word in words)
            {
                bool isExistEveryCahracters = true;
                for(int i=0; i<word.Length; i++)
                {
                    
                        if (!chars.Contains(word[i]))
                        {
                            isExistEveryCahracters = false;
                        }
                    
                }
                if (isExistEveryCahracters)
                    sum += word.Length;

            }
            return sum;
        }
    }
}
