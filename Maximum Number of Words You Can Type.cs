using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Maximum_Number_of_Words_You_Can_Type
    {
        /// <summary>
        /// Already Accepted - try to optimize this one
        /// </summary>
        /// <param name="text"></param>
        /// <param name="brokenLetters"></param>
        /// <returns></returns>
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            int count = 0;

            var array = text.Split(' ');
            foreach (var word in array)
            {   bool isBroken = false;
                for(int i=0; i<brokenLetters.Length; i++)
                {
                    if (word.Contains(brokenLetters[i]))
                    {
                        isBroken = true;
                        break;
                    }
                }
                if(!isBroken)
                    count++;
            }
            return count;
        }
    }
}
