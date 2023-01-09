using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            FirstUniqueCharacterString data = new();

  
          //  IList<IList<string>> matrix = new List<IList<string>>();
            // matrix.Add(new List<string>() { "cat", "bat", "rat" });
            // matrix.Add(new List<string>() { "kzwEQHfwce", "pYyNGfBYbm" });
            //matrix.Add(new List<string>() { "Lima", "Sao Paulo" });

            IList<string> matrix = new List<string>() { "cat", "bat", "rat" };
            string sen= "the cattle was rattled by the battery";
            Console.WriteLine(data.FirstUniqChar("aabb"));

    

          

        }
    }
}
