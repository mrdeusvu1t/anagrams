using System;

namespace AnagramTask
{
    public class Anagram
    {
        /// <summary>
        /// Initialize Anagram object.
        /// </summary>
        /// <param name="sourceWord">Source word.</param>
        /// <exception cref="ArgumentNullException">If source word is null.</exception>
        /// <exception cref="ArgumentException">If source word is empty.</exception>
        public Anagram(string sourceWord)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// From the list of possible anagrams selects the correct subset.
        /// </summary>
        /// <param name="candidates">A list of possible anagrams</param>
        /// <returns>The correct sublist of anagrams.</returns>
        /// <exception cref="ArgumentNullException">If candidates list is null.</exception>
        public string[] FindAnagrams(string[] candidates)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}