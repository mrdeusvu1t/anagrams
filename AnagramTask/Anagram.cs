using System;

namespace AnagramTask
{
    public class Anagram
    {
        /// <summary>
        /// Initialize Anagram object.
        /// </summary>
        /// <param name="sourceWord">Source word.</param>
        /// <exception cref="ArgumentNullException">Thrown when source word is null.</exception>
<<<<<<< HEAD
        /// <exception cref="ArgumentException">Thrown when source word is empty.</exception>
=======
        /// <exception cref="ArgumentException">Thrown when  source word is empty.</exception>
>>>>>>> f8356e8aa6ee01289e15a9d15709105830fd75f2
        public Anagram(string sourceWord)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// From the list of possible anagrams selects the correct subset.
        /// </summary>
        /// <param name="candidates">A list of possible anagrams</param>
        /// <returns>The correct sublist of anagrams.</returns>
        /// <exception cref="ArgumentNullException">Thrown when candidates list is null.</exception>
<<<<<<< HEAD
        /// <example>
        /// word = "Orchestra", candidates = {"cashier", "Carthorse", "radishes"}, anagrams = {"Carthorse"})]
        /// word = "orchestra", candidates = {"caregivers", "Carthorse", "radishes"}, anagrams = {"Carthorse"}
        /// word = "mass", candidates = {"last"}, anagrams = { }
        /// </example>
=======
>>>>>>> f8356e8aa6ee01289e15a9d15709105830fd75f2
        public string[] FindAnagrams(string[] candidates)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
