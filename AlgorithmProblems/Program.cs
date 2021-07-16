using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Based Problems.....");
            //Console.WriteLine("Enter a string to find possible permutations. ");
            //String str = Console.ReadLine();
            //int len = str.Length;
           // Permutatoin.Permute(str, 0, len-1);

            string filePath = File.ReadAllText(@"C:\Users\VIVEK\source\repos\AlgorithmProblems\wordList.txt");
            List<string> words = new List<string>(filePath.Split(" "));
            words.Sort();
            Binarysearch.BinarySearch(words);
        }
    }
}
