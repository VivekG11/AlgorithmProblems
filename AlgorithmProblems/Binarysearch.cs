using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public class Binarysearch<T> where T:IComparable
    {

        public static void BinarySearch(List<T> wordList)
        {
            int start = 0;
            int mid = 0;
            int end = wordList.Count - 1;
            bool found = false;
            Console.WriteLine("Enter a word you want to search in list :");
            string search=Console.ReadLine();
            while(start<=end)
            {
                mid = (start + end) / 2;
                int res = search.CompareTo(wordList[mid]);
                if(res == 0)
                {
                    Console.WriteLine("Entered word is present.");
                    found = true;
                    break;
                }
                else if(res>0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if(!found)
            {
                Console.WriteLine("Entered word does not exist in the wordlist.");
            }
        }
    }
}
