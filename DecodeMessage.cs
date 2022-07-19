 public static class DecodeMessage
    {
        public static string DecodeMessageSolution(string key, string message)
        {
            string decodeMessage = "";

            Dictionary<char, char> dict = new Dictionary<char, char>()
        {
            {' ', ' '}
        };


            foreach (char c in key)
            {
                if (dict.ContainsKey(c)) continue;
                dict.Add(c, Convert.ToChar('a' + dict.Count() - 1));
            }

            foreach (char c in message)
            {
                decodeMessage += dict[c];
            }
            return decodeMessage;
        }
    }
