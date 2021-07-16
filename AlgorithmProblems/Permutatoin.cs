using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Permutatoin
    {
        public static void Permute(string str , int start , int last )
        {
            if(start == last)
            {
                Console.WriteLine(str);
            }
            else
            {
                for(int i = start; i <= last; i++)
                {
                    str = Swap(str, start, i);
                    Permute(str, start+1, last);
                    str = Swap(str, start, i);
                }
            }
        }

        public static string Swap(string S , int a , int b)
        {
            char temp;
            char[] charArray = S.ToCharArray();
            temp = charArray[a];
            charArray[a] = charArray[b];
            charArray[b] = temp;
            string perm = new string(charArray);
            return perm;
            
           
        }
    }
}
