using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Determine_if_Two_Events_Have_Conflict
    {
        public bool HaveConflict(string[] event1, string[] event2)
        {

            TimeSpan event1Startime = TimeSpan.Parse(event1[0]);
            TimeSpan event1Endtime = TimeSpan.Parse(event1[1]);
            TimeSpan event2Starttime = TimeSpan.Parse(event2[0]);
            TimeSpan event2Endtime = TimeSpan.Parse(event2[1]);

             return !(event1Startime >= event2Endtime || event2Starttime >= event1Endtime);

        }
    }
}
