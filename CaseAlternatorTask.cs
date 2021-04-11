using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            if (startIndex == word.Length)
            {
                string wordStr = new string(word);

                if (!result.Contains(wordStr))
                {
                    result.Add(new string(wordStr.ToCharArray()));
                }
            }
            else
            {
                if (Char.IsLetter(word[startIndex]))
                {
                    word[startIndex] = Char.ToLower(word[startIndex]);
                    AlternateCharCases(word, startIndex + 1, result);
                    word[startIndex] = Char.ToUpper(word[startIndex]);
                    AlternateCharCases(word, startIndex + 1, result);
                }
                else
                    AlternateCharCases(word, startIndex + 1, result);
            }
        }
    }
}

