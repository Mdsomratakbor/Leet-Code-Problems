using System;
using System.Text;

public class LongestCommonPrefix
{
        public string LongestCommonPrefixSolution(string[] strs)
        {
            StringBuilder result = new StringBuilder();
            int firstStringLength = strs[0].Length;
            int arrayLength = strs.Length;
            for (int i = 0; i < firstStringLength; i++)
            {

                for (int j = 1; j < arrayLength; j++)
                {
                    if (strs[j].Length <= i)
                        return result.ToString();

                    if (strs[0][i] != strs[j][i])
                    {
                        return result.ToString();
                    }
                }
                result.Append(strs[0][i]);
            }
            return result.ToString();
        }
    
}
