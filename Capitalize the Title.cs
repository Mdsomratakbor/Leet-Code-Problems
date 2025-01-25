using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Capitalize_the_Title
    {
        public string CapitalizeTitle(string title)
        {
            StringBuilder convertedTitle = new StringBuilder();

            int length = 0;
            bool isSpaceFound = true; // Start as if a space was found to handle the first word
            string temporaryWord = "";

            while (length < title.Length)
            {
                if (title[length] == ' ') // Space encountered
                {
                    if (temporaryWord.Length > 2) // Capitalize if word length > 2
                    {
                        convertedTitle.Append(char.ToUpper(temporaryWord[0]));
                        convertedTitle.Append(temporaryWord.Substring(1).ToLower());
                        convertedTitle.Append(' ');
                    }
                    else if (temporaryWord.Length > 0) // Append short words as lowercase
                    {
                        convertedTitle.Append(temporaryWord.ToLower());
                        convertedTitle.Append(' ');
                    }
                    else
                    {
                        convertedTitle.Append(' '); // Preserve multiple spaces
                    }
                    temporaryWord = ""; // Reset temporary word
                    isSpaceFound = true;
                }
                else // Character encountered
                {
                    if (isSpaceFound)
                    {
                        temporaryWord += title[length]; // Start a new word
                        isSpaceFound = false;
                    }
                    else
                    {
                        temporaryWord += title[length]; // Continue the current word
                    }
                }

                length++;
            }

            // Handle the last word (if there's no trailing space)
            if (temporaryWord.Length > 2)
            {
                convertedTitle.Append(char.ToUpper(temporaryWord[0]));
                convertedTitle.Append(temporaryWord.Substring(1).ToLower());
            }
            else if (temporaryWord.Length > 0)
            {
                convertedTitle.Append(temporaryWord.ToLower());
            }

            return convertedTitle.ToString();
        }



        public string CapitalizeTitle_Second(string title)
        {
            StringBuilder convertedTitle = new StringBuilder();
            string[] words = title.Split(' '); // Split the title into words by spaces

            foreach (string word in words)
            {
                if (word.Length > 2) // Capitalize words with more than 2 characters
                {
                    convertedTitle.Append(char.ToUpper(word[0]));
                    convertedTitle.Append(word.Substring(1).ToLower());
                }
                else // Keep shorter words lowercase
                {
                    convertedTitle.Append(word.ToLower());
                }
                convertedTitle.Append(' '); // Add space after each word
            }

            return convertedTitle.ToString().TrimEnd(); // Trim the trailing space
        }


    }
}
