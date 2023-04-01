using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class CourseSchedule
    {
        Dictionary<int, List<int>> schedules = new Dictionary<int, List<int>>();

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            for(int i=0; i<prerequisites.Length; i++)
            {
                if (schedules.ContainsKey(prerequisites[i][1]))
                {
                    schedules[prerequisites[i][1]].Add(prerequisites[i][0]);
                }
                else
                    schedules.Add(prerequisites[i][1],new List<int>() { prerequisites[i][0] });
            }

            int[] visited = new int[numCourses+1];

            for(int i=0; i<numCourses; i++)
            {
                if (!Dfs(schedules, visited, i))
                    return false;
            }
            return true;
        }
        public bool Dfs(Dictionary<int, List<int>> map, int[] visited, int i)
        {
            if (visited[i]==-1) return false;
            if (visited[i]==1) return true;
            visited[i] = -1;
            if (map.ContainsKey(i))
            {
                foreach (var j in map[i])
                {
                    if (!Dfs(map, visited, j))
                    {
                        return false;
                    }
                }
            }
           
            visited[i] = 1;
            return true;
        }
    }
}
  