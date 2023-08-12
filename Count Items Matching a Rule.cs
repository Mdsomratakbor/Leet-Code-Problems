using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_Items_Matching_a_Rule
    {

        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

           Dictionary<string, int> keys = new Dictionary<string, int>()
           {
               {"type", 0 },
               {"color", 1 },
               {"name", 2 }
           };

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i][keys[ruleKey]]== ruleValue) count++;
            }

                return count;

        }

        public int CountMatches_old(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

            if (ruleKey=="type")
            {
                foreach (var item in items)
                {
                    if (item[0]== ruleValue)
                    {
                        count++;
                    }
                }
            }
            else if (ruleKey == "color")
            {
                foreach (var item in items)
                {
                    if (item[1]== ruleValue)
                    {
                        count++;
                    }
                }
            }
            else
            {
                foreach (var item in items)
                {
                    if (item[2]== ruleValue)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
