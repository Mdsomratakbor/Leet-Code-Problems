using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_Vowel_Strings_in_Ranges
    {


        public int[] VowelStrings(string[] words, int[][] queries)
        {
            int queriesLength = queries.Length;
            int wordsLength = words.Length;
            int[] prefixSum = new int[wordsLength];
            int sum = 0;

            for (int i = 0; i<wordsLength; i++)
            {
                if (VowelCheck(words[i][0]) && VowelCheck(words[i][words[i].Length-1]))
                {
                    sum++;
                }
                prefixSum[i] = sum;
            }
            int[] result = new int[queriesLength];

            int index = 0;
            foreach (var query in queries)
            {

                result[index++] = (int)prefixSum[query[1]]-(query[0] - 1 >= 0 ? (int)prefixSum[query[0] - 1] : 0);

            }
            return result;
        }
        /// <summary>
        /// Time Limit Exceeded Using this approach 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        //public int[] VowelStrings(string[] words, int[][] queries)
        //{

        //    int queriesLength = queries.Length;
        //    int wordsLength = words.Length;

        //    int[] result = new int[queriesLength];

        //    for (int i = 0; i<queriesLength; i++)
        //    {
        //        int count = 0;
        //        var (initialIndex, lastIndex) = (queries[i][0], queries[i][1]);

        //        for (int j = initialIndex; j<=lastIndex; j++)
        //        {
        //            string currentWord = words[j];
        //            int currentWordLength = currentWord.Length;
        //                if (VowelCheck(currentWord[0]) && VowelCheck(currentWord[currentWordLength-1]))
        //                {
        //                    count++;
        //                }
        //        }
        //        result[i]=count;
        //    }
        //    return result;
        //}
        private bool VowelCheck(char value)
        {
            return value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u';
        }
    }
}
