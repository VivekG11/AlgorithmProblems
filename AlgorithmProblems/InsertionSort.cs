using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class InsertionSort
    {
        public void insertionSort(int[] arr)
        {
            int n = arr.Length;
            int i, j, key;
            for(i = 1; i<n ;i++)
            {
                key = arr[i];
                j = i - 1;
                while (j>=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
         
        public  void printArray(int[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("Elements after sorted are :");
            for(int i = 0; i < n; ++i)
            {
                Console.Write(arr[i]+",");
            }
        }
    }
}
