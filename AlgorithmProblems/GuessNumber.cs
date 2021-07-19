using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class GuessNumber
    {
        //Initialize lower limit and upper limit
        public  int low = 1;
        public  int high = 100;

        //Method to find mid value in a range
        public  int Mid()
        {
            int mid = (low + high) / 2;
            Console.WriteLine("Mid is :"+mid);
            return mid;
        }

        //Compare guessed nuber with mid value
        public  void Guess(int mid)
        {
            Console.WriteLine("1.Number is less than Mid");
            Console.WriteLine("2.Number is graeter than Mid");
            Console.WriteLine("3.Number found :");
            Console.WriteLine("Enter your choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    high = mid - 1;
                    break;
                case 2:
                    low = mid + 1;
                    break;
                case 3:
                    Console.WriteLine("NUmber is  :"+mid);
                    break;
                default:
                    Console.WriteLine("Enter valid option.");
                    break;
            }
           
        }

        public void Number()
        {
           
            while (low != high)
            {
                int mid = Mid();
                Guess(mid);
            }
            if (low == high)
            {
                Console.WriteLine("Number is :" + low);
               
            }
        }

    }
}
