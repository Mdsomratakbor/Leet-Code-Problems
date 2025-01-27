using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Divide_a_String_Into_Groups_of_Size_k
    {
        public string[] DivideString(string s, int k, char fill)
        {
            int length = s.Length;
            int parts = Convert.ToInt32(Math.Ceiling((decimal)length / k));
            string[] strings = new string[parts];

            for (int i = 0; i < parts; i++)
            {
                int lastPartValue = (i * k) + k;
                if (lastPartValue > length)
                {
                    strings[i] = s.Substring((i * k), length - (i * k));
                    if (strings[i].Length != k)
                    {
                        int lastWordLength = k- strings[i].Length;
                        for(int j=0; j< lastWordLength; j++)
                        {
                            strings[i] += fill;
                        }
                    }
                }
                else
                {
                    strings[i] = s.Substring(i * k, k);

                }

            }

            return strings;

        }
    }
}
