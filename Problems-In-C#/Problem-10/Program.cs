using System;
using System.Numerics;
using MathLibrary;


namespace ProjectEuler.Problems.Problem9
{
    class SummationOfPrimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summation Of Primes");

            SummationOfPrimes spt = new SummationOfPrimes();

            BigInteger stop = 2000000;

            BigInteger result = spt.SummationWithPrimes(stop);

            Console.WriteLine("Answer: " + result);

            Console.ReadKey();
        }

        public BigInteger SummationWithPrimes(BigInteger stop)
        {
            if (stop < 2) return 0;

            BigInteger result = 2;
            
            for (BigInteger i = 2; i <= stop;) {

                i = Utils.nextPrime(i);
                if (i > stop) break;
                result += i;
            }

            return result;
        }
    }
}

