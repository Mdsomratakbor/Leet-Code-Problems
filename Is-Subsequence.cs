﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Is_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int j = 0;
            if (s.Length > t.Length) return false;
            for (int i = 0; i < t.Length && j < s.Length; i++)
                if (s[j] == t[i])
                    j++;
            return j == s.Length;

        }
    }
}
