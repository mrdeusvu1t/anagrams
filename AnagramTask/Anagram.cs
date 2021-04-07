using System;
using System.Collections.Generic;

namespace AnagramTask
{
    public class Anagram
    {
        public string SourceWord { get; set; }
        public List<string> list = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Anagram"/> class.
        /// </summary>
        /// <param name="sourceWord">Source word.</param>
        /// <exception cref="ArgumentNullException">Thrown when source word is null.</exception>
        /// <exception cref="ArgumentException">Thrown when  source word is empty.</exception>
        public Anagram(string sourceWord)
        {
            if (sourceWord is null)
            {
                throw new ArgumentNullException("word is null");
            }

            if (sourceWord.Length == 0)
            {
                throw new ArgumentException("word is empty");
            }

            SourceWord = sourceWord;
        }

        /// <summary>
        /// From the list of possible anagrams selects the correct subset.
        /// </summary>
        /// <param name="candidates">A list of possible anagrams.</param>
        /// <returns>The correct sublist of anagrams.</returns
        /// <exception cref="ArgumentNullException">Thrown when candidates list is null.</exception>
        public string[] FindAnagrams(string[] candidates)
        {
            if (candidates is null)
            {
                throw new ArgumentNullException("array is null");
            }

            foreach (string candidate in candidates)
            {
                if (IsAnagram(SourceWord.ToLower(), candidate.ToLower()))
                {
                    list.Add(candidate);
                }
            }

            return list.ToArray();
        }

        private bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            if (s1 == s2)
            {
                return false;
            }

            foreach (char c in s2)
            {
                int x = s1.IndexOf(c);

                if (x >= 0)
                {
                    s1 = s1.Remove(x, 1);
                }
                else
                {
                    return false;
                }          
            }

            return string.IsNullOrEmpty(s1);
        }
    }
}
