using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Letter_Combinations_of_a_Phone_Number
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            Dictionary<char, string> digitsWithValue = new Dictionary<char, string>()
                {
                    { '2', "abc" },
                    { '3', "def" },
                    { '4', "ghi" },
                    { '5', "jkl" },
                    { '6', "mno" },
                    { '7', "pqrs" },
                    { '8', "tuv" },
                    { '9', "wxyz" }
                };



            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }
            result.Add("");
            foreach(var digit in digits)
            {
                string letters = digitsWithValue[digit];
                List<string> newResult = new List<string>();

                foreach(var letter in letters) {

                    foreach (string combination in result)
                    {
                        newResult.Add(combination + letter);
                    }
                }

                result = newResult;
            }

            return result;
        }
    }
}
