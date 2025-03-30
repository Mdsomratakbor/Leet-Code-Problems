using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leet_Code_Problems
{
    public class Check_if_Word_Equals_Summation_of_Two_Words
    {
     public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        int firstValue = ConvertWordToNumber(firstWord);
        int secondValue = ConvertWordToNumber(secondWord);
        int targetValue = ConvertWordToNumber(targetWord);

        return firstValue + secondValue == targetValue;
    }

    private int ConvertWordToNumber(string word)
    {
       int num  = 0;
        foreach (char c in word)
        {
            num = num * 10 + (c - 'a');
        }
        return num;
    }
        
    }
}