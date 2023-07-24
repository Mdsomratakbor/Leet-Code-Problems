using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Truncate_Sentence
    {
        public string TruncateSentence(string s, int k)
        {
            string[] sArray = s.Split(" ");
            StringBuilder sb =new StringBuilder();
            for(int i=0; i<k; i++)
            {
                if(sb.Length>0)
                    sb.Append(" ");

                sb.Append(sArray[i]);

            }    
            return sb.ToString();
        }
    }
}
