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
    }
}
