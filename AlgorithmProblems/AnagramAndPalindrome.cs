using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public class AnagramAndPalindrome
    {
       public static int Prime(int num)
        {
            int h = num / 2;
             int flag = 0;
            for(int i = 2; i <= h; i++)
            {
                if(num % i == 0)
                {
                    flag = 1;
                    Console.WriteLine("Entered num is prime.");
                    break;
                }
            }
            if(flag == 0)
            {
               
                return flag;
            }
            return 0;

        }

        public static bool Palindrome(int num)
        {
            int rem, rev = 0, temp;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
            if (temp == rev)
            {
                Console.WriteLine("Entered num is palindrome.");
                return true;
            }
            else
            {
                Console.WriteLine("Not a palindrome");
                return false;
            }
        }

        public static bool Anagram(string str1 , string str2)
        {
            Console.WriteLine("Enter two value :");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string firstString = new string(arr1);
            string secondString = new string(arr2);

            if(firstString == secondString)
            {
                Console.WriteLine("Entered values are anagrams.");
                return true;
            }
            else
            {
                Console.WriteLine("Not palindromes.");
                return false;
            }
        }
       
    }
}
