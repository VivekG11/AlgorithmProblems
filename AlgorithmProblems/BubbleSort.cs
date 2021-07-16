using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public class BubbleSort
    {
        public  void Sort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public void Display(int[] arr)
        {
            Console.WriteLine("Elements after sorted are :");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
        }
        

    }
}
