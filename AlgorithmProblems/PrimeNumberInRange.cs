using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
   public class PrimeNumberInRange
    {
       
        public  void Prime()
        {
            int count = 0;
            int limit = 1000;
            int num = 0;
            for (int i = 1; i < limit; i++)
            {
                for(int j = 1; j < limit; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                   
                    Console.Write(i+",");
                    num++;
                }
                
                count = 0;
            }
            Console.WriteLine("\nTotal Prime Numbers in range are :"+num);
        }
    }
}
