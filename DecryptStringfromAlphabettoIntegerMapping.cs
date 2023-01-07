using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class DecryptStringfromAlphabettoIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while(i<s.Length-2)
            {
                char ch;
               
                    if (s[i+2]=='#')
                    {

                    var data = s.Substring(3, i+1);
                        ch = (char)Convert(s.Substring(i, i+1));
                    Console.WriteLine(s);
                    i+=3;
                }
                    else 
                {
                    ch = (char)Convert(s.Substring(i, i+1));
                    i++;
                }
                sb.Append(ch);

            }
            while (i<s.Length)
            {
                char ch = (char)Convert(s.Substring(i, i+1));
                sb.Append(ch);
                i++;
            }
            return sb.ToString();
    }

        private char Convert(string v)
        {
   
            int num = Int16.Parse(v);
            return (char)(num+96);
        }
    }
}
