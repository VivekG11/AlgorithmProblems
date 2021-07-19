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
            Console.WriteLine("Enter a choice to perform operation :");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                 Console.WriteLine("Algorithm Based Problems.....");
            Console.WriteLine("Enter a string to find possible permutations. ");
            String str = Console.ReadLine();
            int len = str.Length;
            Permutatoin.Permute(str, 0, len - 1);
                    break;
                case 2:

            string filePath = File.ReadAllText(@"C:\Users\VIVEK\source\repos\AlgorithmProblems\wordList.txt");
            List<string> words = new List<string>(filePath.Split(" "));
            words.Sort();
            Binarysearch<string>.BinarySearch(words);
                    break;
                case 3:

            
            int[] arr = { 12, 13, 29, 11, 04, 17 };
            InsertionSort<int> insertionSort = new InsertionSort<int>();
            insertionSort.insertionSort(arr);
            insertionSort.printArray(arr);
                    break;
                case 4:
                    int[] array = { 20, 10, 40, 50, 60 };
                    BubbleSort<int> bubbleSort = new BubbleSort<int>();
                    bubbleSort.Sort(array);
                    bubbleSort.Display(array);
                    break;
                case 5:
                    int[] num = { 12, 23, 13, 26, 27, 11, 07, 29, 11, 17 };
                    MergeSort<int> mergeSort = new MergeSort<int>();
                    mergeSort.Sort(num, 0,num.Length-1);
                    mergeSort.PrintArray(num);
                    break;
                case 6:
                    Anagram.FindAnagram();
                    break;
                case 7:
                    PrimeNumberInRange primeNumber = new PrimeNumberInRange();
                    Console.WriteLine("Prime Numbers are :");
                    primeNumber.Prime();
                    break;
              
                case 8:
                    GuessNumber guess = new GuessNumber();
                    guess.Number();
                    break;
                case 9:
                    RegexMessage.DisplayMessage();
                    break;
                default:
                    Console.WriteLine("Enter valid option :");
                    break;
        }

        }
    }
}
