using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Check_if_Numbers_Are_Ascending_in_a_Sentence
    {
        public bool AreNumbersAscending(string s)
        {
            int number = 0;
            var newArray = s.Split(' ').ToList();

            for(int i =0; i< newArray.Count; i++)
            {

                int currentCharacter = 0;
                if (int.TryParse(newArray[i], out currentCharacter))
                {
                    if (number < currentCharacter)
                    {
                        number = currentCharacter;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
