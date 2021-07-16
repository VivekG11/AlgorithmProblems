using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public static class Anagram
    {
        public static void FindAnagram()
        {
            string string1 = "abcd";
            string string2 = "dcba";
            char[] ch1 = string1.ToLower().ToCharArray();
            char[] ch2 = string2.ToLower().ToCharArray();
            //use Array.Sort method to sorts the charecters in the char arrays

            Array.Sort(ch1);
            Array.Sort(ch2);

           
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            //Compare both array values after sorting
            if (val1 == val2)
            {
                Console.WriteLine("Entered strings are Anagrams.");
            }
            else
            {
                Console.WriteLine("Not Anagrams.");
            }
        }

    }
}
