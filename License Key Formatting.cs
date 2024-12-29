using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class License_Key_Formatting
    {

        public string LicenseKeyFormatting(string s, int k)
        {
            StringBuilder formatted = new StringBuilder();
            int count = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '-')
                {
                    if (count == k)
                    {
                        formatted.Append('-');
                        count = 0;
                    }
                    formatted.Append(char.ToUpper(s[i]));
                    count++;
                }
            }

            // Reverse the string as we built it from the back
            return new string(formatted.ToString().Reverse().ToArray());
        }


        public string LicenseKeyFormatting__10PercentOptimized(string s, int k)
        {

            StringBuilder newStringBuilder = new StringBuilder();
            int count = 0;
            int i = s.Length - 1;
            while (i >= 0)
            {

                
                if (s[i] != '-')
                {
                    if (count >= k)
                    {
                        newStringBuilder.Insert(0, '-');
                        count = 0;
                        continue;
                    }
                    newStringBuilder.Insert(0, char.ToUpper((s[i])));
                    count++;
                }
                i--;
            }
            return newStringBuilder.ToString();
        }
    }
}
