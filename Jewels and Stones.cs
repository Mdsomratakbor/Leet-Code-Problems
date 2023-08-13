using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Jewels_and_Stones
    {
        /// <summary>
        /// 88% optimized
        /// </summary>
        /// <param name="jewels"></param>
        /// <param name="stones"></param>
        /// <returns></returns>
        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();


            for (int j = 0; j < stones.Length; j++)
            {
                if (map.ContainsKey(stones[j]))
                {
                    map[stones[j]]++;
                }
                else
                {
                    map[stones[j]] = 1;
                }
            }

            for (int i = 0; i < jewels.Length; i++)
            {
                if (map.ContainsKey(jewels[i]))
                {
                    count += map[jewels[i]];
                }
            }
            return count;
        }


        /// <summary>
        /// Needed to optimize the time coplexity
        /// </summary>
        /// <param name="jewels"></param>
        /// <param name="stones"></param>
        /// <returns></returns>
        public int NumJewelsInStones_old(string jewels, string stones)
        {
            int count = 0;
            for (int i = 0; i < jewels.Length; i++)
            {
                for (int j = 0; j < stones.Length; j++)
                {
                    if (jewels[i] == stones[j])
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
