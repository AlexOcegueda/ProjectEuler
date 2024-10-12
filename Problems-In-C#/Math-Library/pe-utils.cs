using System;
using System.Numerics;

namespace MathLibrary
{
    public class Utils
    {
        /*
         * Function: isPrime
         * ----------------------------
         *   Determines if a long long integer is prime.
         *
         *   start: The BigInteger to check for primality.
         *
         *   returns: true if start is a prime number, false otherwise.
         */
        public static bool isPrime(BigInteger start) 
        {
            if (start <= 1) 
            {
                return false;
            }

            if (start <= 3) 
            {
                return true;
            }

            if (start % 2 == 0 || start % 3 == 0) 
            {
                return false;
            }

            // Only need to check up to sqrt(start) since it restarts after getting to this point
            BigInteger end = (BigInteger) Math.Floor(Math.Sqrt((double) start));

            for (BigInteger i = 5; i <= end; i += 6)
            {
                if (start % i == 0 || start % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /*
         * Function: nextPrime
         * ----------------------------
         *   Finds the next prime number greater than a given start.
         *
         *   start: The starting BigInteger.
         *
         *   returns: The next prime number greater than start.
         */
        public static BigInteger nextPrime(BigInteger start) 
        {
            if (start <= 1) 
            {
                return 2;
            }

            do 
            {
                start++;
            } while (!isPrime(start));

            return start;
        }

        /*
         * Function: isPalindrome
         * ------------------------------
         *  Returns bool on whether the number is a palindrome

         *  str: Int number as a string
         *
         *  length: Length of string/number
         *
         *  mid: Middle of string length
         *
         *  firstHalf: First half of number
         *
         *  secondHalf: Second half of number 
         */
        public static bool isPalindrome(int number)
        {
            string str = number.ToString();
            int length = str.Length;
            int mid = length / 2;

            string firstHalf = "";
            string secondHalf = "";

            // Handle single-digit numbers as a special case
            if (length == 1) 
            {
                return true;
            }

            // Get the first half of the number
            for (int i = 0; i < mid; i++)
            {
                firstHalf += str[i];
            }

            // Get the second half of the number (in reverse order)
            // If the number has an odd number of digits, skip the middle one
            for (int j = length - 1; j >= (length % 2 == 0 ? mid : mid + 1); j--)
            {
                secondHalf += str[j];
            }

            return firstHalf == secondHalf;
        }
    }
}
