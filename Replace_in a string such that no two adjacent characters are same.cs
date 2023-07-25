using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Replace_in_a_string_such_that_no_two_adjacent_characters_are_same
    {
        ///  Replace ‘?’ in a string such that no two adjacent characters are same
        ///  

        public string ModifyString(string s)
        {
            char[] newArray = s.ToArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (newArray[i] == '?')
                {
                    newArray[i] = 'a';
                    if (newArray.Length > 1)
                    {
                        if (i != 0 && i < s.Length - 1)
                        {
                            if (newArray[i - 1] == newArray[i])
                            {
                                newArray[i] = Convert.ToChar(newArray[i] + 1);
                            }
                            if (newArray[i + 1] == newArray[i])
                            {
                                newArray[i] = Convert.ToChar(newArray[i] + 1);
                            }
                            if (newArray[i - 1] == newArray[i])
                            {
                                newArray[i] = Convert.ToChar(newArray[i] + 1);
                            }
                        }
                        if (i == 0)
                        {
                            if (newArray[i + 1] == newArray[i])
                            {
                                newArray[i] = Convert.ToChar(newArray[i] + 1); ;
                            }
                        }
                        if (i == s.Length-1)
                        {
                            if (newArray[i - 1] == newArray[i])
                            {
                                newArray[i] = Convert.ToChar(newArray[i] + 1); ;
                            }
                        }
                    }
                }
            }
            string result = new string(newArray);
            return result;
        }


        // Another way
        //public string ModifyString(string s)
        //{
        //    char[] newArray = s.ToCharArray();
        //    int n = s.Length;

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (newArray[i] == '?')
        //        {
        //            char prev = (i > 0) ? newArray[i - 1] : ' ';
        //            char next = (i < n - 1) ? newArray[i + 1] : ' ';

        //            char candidate = 'a';
        //            while (candidate == prev || candidate == next)
        //            {
        //                candidate++;
        //            }
        //            newArray[i] = candidate;
        //        }
        //    }

        //    return new string(newArray);
        //}
    }
}
