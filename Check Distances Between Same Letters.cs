using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Check_Distances_Between_Same_Letters
    {
        public bool CheckDistances(string s, int[] distance)
        {
            bool isDistanceOkay = true;

            for(int i=0; i<s.Length; i++)
            {
                int count = 0;
                for(int j = i+1; j<s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        for (int d = 0; d < distance.Length; d++)
                        {
                            if (Convert.ToChar(d + 97) == s[i] && distance[d] == count)
                            {
                                isDistanceOkay = true;
                                break;
                            }
                            else
                            {
                                isDistanceOkay = false;
                            }
                        }
                        if (!isDistanceOkay)
                            return isDistanceOkay;
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                
            }
            return isDistanceOkay;
        }

    }
}
