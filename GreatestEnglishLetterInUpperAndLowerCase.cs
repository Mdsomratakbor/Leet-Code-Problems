using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string GreatestLetter(string s) {
      
        Dictionary<char, bool> dict = new Dictionary<char, bool>();

            int size = s.Length;
            for (int i = 0; i < size; i++)
            {
                if (dict.ContainsKey(s[i])) continue;
                if (Char.IsUpper(s[i]))
                {                
                     dict.Add(s[i], false);   
                }                                               
            }
            foreach (var data in dict)
            {
                foreach(var sm in s)
                {
                    if(char.ToLower(data.Key) == sm)
                    {
                        dict[data.Key] = true;
                    }
                   
                }
            }
          var sortedDictionary = new SortedDictionary<char, bool>(dict);

            return sortedDictionary.LastOrDefault(x=>x.Value==true).Key.ToString()=="\u0000"?"": sortedDictionary.LastOrDefault(x => x.Value == true).Key.ToString();
    }
}
