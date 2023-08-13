using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Student_Attendance_Record_I
    {
        public bool CheckRecord(string s)
        {
            int absenseCount = 0;
            for (int i=0; i<s.Length; i++)
            {

                if ( s[i] == 'A')
                {
                    absenseCount++;
                    if (absenseCount >= 2)
                        return false;
                }
                else if (s[i] == 'L')
                {
                    int lateCount = 0;
                    for (int j = i; j < s.Length; j++)
                    {

                        if (s[i] != s[j])
                        {
                            break;
                        }
                       else if (s[i] == s[j] && s[i] == 'L')
                        {
                            lateCount++;
                            if (lateCount >= 3)
                                return false;
                        }
                    }
                }
             
              



            }
            return true;
        }
    }
}
