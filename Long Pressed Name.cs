using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Long_Pressed_Name
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int left =0, right = 0;
            while (right<typed.Length)
            {
                if(left<name.Length && name[left]== typed[right])
                {
                    right++;
                    left++;
                }
                else if(right>0 && typed[right] == typed[right - 1])
                {
                    right++;
                }
                else
                {
                    // If no match and no repeat, it's not a valid long press
                    return false;
                }

            }
            return left == name.Length;
        }
            public bool IsLongPressedNameOld(string name, string typed)
        {
            Dictionary<char, int> mapNameCharacters= new Dictionary<char, int>();
            Dictionary<char, int> mapTypedCharacters = new Dictionary<char, int>();

            foreach (char c in typed)
            {
                if (mapTypedCharacters.ContainsKey(c))
                {
                    mapTypedCharacters[c] +=1;
                }
                else
                {
                    mapTypedCharacters.Add(c, 1);
                }
            }
            
            foreach (char c in name)
            {
                if (mapNameCharacters.ContainsKey(c))
                {
                    mapNameCharacters[c] += 1;
                }
                else
                {
                    mapNameCharacters.Add(c, 1);
                }
            }



            foreach (var keyValuePair in mapNameCharacters)
            {
                int index = GetIndexByKey(mapTypedCharacters, keyValuePair.Key);
                int index2 = GetIndexByKey(mapNameCharacters, keyValuePair.Key);
                if (index == -1 || index2 == -1)
                    return false;

                if (index != index2)
                    return false;
                if (!mapTypedCharacters.ContainsKey(keyValuePair.Key) || mapTypedCharacters[keyValuePair.Key] < keyValuePair.Value)
                    return false;
            }



            return true;

        }

        int GetIndexByKey(Dictionary<char, int> dictionary, char key)
        {
            int index = 0;
            foreach (var kvp in dictionary)
            {
                if (kvp.Key == key)
                    return index;
                index++;
            }
            return -1; // Return -1 if the key is not found
        }
    }
}
