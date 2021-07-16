using System;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Based Problems.....");
            Console.WriteLine("Enter a string to find possible permutations. ");
            String str = Console.ReadLine();
            int len = str.Length;
            Permutatoin.Permute(str, 0, len-1);

        }
    }
}
