using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            DestinationCity data = new();
            IList<IList<string>> matrix = new List<IList<string>>();
            matrix.Add(new List<string>() { "pYyNGfBYbm", "wxAscRuzOl" });
            matrix.Add(new List<string>() { "kzwEQHfwce", "pYyNGfBYbm" });
            //matrix.Add(new List<string>() { "Lima", "Sao Paulo" });
            Console.WriteLine(data.DestCity(matrix));
          

        }
    }
}
