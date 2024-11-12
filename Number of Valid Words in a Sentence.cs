using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Number_of_Valid_Words_in_a_Sentence
    {
        public int CountValidWords(string sentence)
        {
            int count = 0;
            //A sentence consists of lowercase letters ('a' to 'z'), digits ('0' to '9'), hyphens ('-'), punctuation marks ('!', '.', and ','), and spaces (' ') only. Each sentence can be broken down into one or more tokens separated by one or more spaces ' '.


            string[] strings = sentence.Split(' ');

            string punctuationMark = "!.,";
            string letters = "abcdefghijklmnopqurstwxyz";
            string digits = "0123456789";
            char hypen = '-';
            foreach (string s in strings)
            {
                for (int i = 0; i < s.Length; i++)
                {

                }
            }
            return count;
        }
    }
}
