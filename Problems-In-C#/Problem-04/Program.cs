using System;
using System.Numerics;
using MathLibrary;

namespace ProjectEuler.Problems.Problem4
{
    class LargestPalindromeProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Palindrome Product");

            LargestPalindromeProduct lpp = new LargestPalindromeProduct();

            int goal = 999; // three digits

            int result = lpp.FindLargestPalindromeProduct(goal);

            Console.WriteLine("Answer: " + result);

            Console.ReadKey();
        }

        public int FindLargestPalindromeProduct(BigInteger goal)
        {
            int max = 0;
            int start = 1;

            while(start <= goal)
            {
                int end = start;

                while(end <= goal)
                {
                    int product = start*end;
                    if(Utils.isPalindrome(product))
                    {
                        if(max < product)
                        {
                            max = product;
                        }
                    }
                    end += 1;
                }
                start += 1;
            }
            return max;
        } 
    }
}
