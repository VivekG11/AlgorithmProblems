using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public  class MergeSort<T> where T:IComparable
    {
        public  void Merge(T[] arr, int start, int mid, int end)
        {
            int n1 = mid - start + 1;
            int n2 = end - mid;
            int i, j;
            T[] Left = new T[n1];
            T[] Right = new T[n2];
            
            for(i = 0; i < n1; ++i)
            {
                Left[i] = arr[start + i];
            }
            for(j = 0; j < n2; ++j)
            {
                Right[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;

            int k = 1;
            while(i < n1 && j < n2)
            {
                if(Left[i].CompareTo(Right[j]) < 0 || Left[i].CompareTo(Right[j])==0)
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;

                while(i < n1)
                {
                    arr[k] = Left[i];
                    i++;
                    k++;
                }
                while (j < n2)
                {
                    arr[k] = Right[j];
                    j++;
                    k++;
                }
            }

            

        }
        public void Sort(T[] arr, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                Sort(arr, start, end);
                Sort(arr, mid + 1, end);
                Merge(arr, start, mid,end);
            }
        }

        public void PrintArray(T[] arr)
        {
            int num = arr.Length;
            Console.WriteLine("Elements after sorted are :");
            for(int i = 0; i < num; i++)
            {
                Console.Write(arr[i]+",");
            }
        }
    }
}
