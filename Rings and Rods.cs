using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCodeProblems;
public class Rings_And_Rods{
     public int CountPoints(string rings) {
        Dictionary<int, HashSet<char>> keyValuePairs = new Dictionary<int, HashSet<char>>();

      for (int i = 0; i < rings.Length; i+=2) {
            char color = rings[i];
            int rod = rings[i+1]-'0';

              if(!keyValuePairs.ContainsKey(rod)){
                keyValuePairs[rod] = new HashSet<char>();
            }
              keyValuePairs[rod].Add(color);
        }

         int count = 0;
        foreach (var rod in keyValuePairs.Values) {
            if (rod.Contains('R') && rod.Contains('G') && rod.Contains('B')) {
                count++;
            }
        }

        return count;
       
    }
}