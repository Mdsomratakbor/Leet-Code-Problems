using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class DestinationCity
    {
        public string DestCity(IList<IList<string>> paths)
        {
            string temp1 = string.Empty;
            string temp2 = string.Empty;
            string destination = string.Empty;
            foreach (var path in paths)
            {
                temp1 = path.LastOrDefault();
                foreach (var data in path)
                {
                    temp2 = data;
                    if (temp1 == data)
                    {
                        destination = data;
                    }
                    else if (temp1 == destination)
                    {
                        destination = temp1;
                    }
                }
            }
            return destination;
        }
    }
}
