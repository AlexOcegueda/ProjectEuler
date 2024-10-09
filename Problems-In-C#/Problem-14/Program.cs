using System;
using System.Numerics;

namespace ProjectEuler.Problems.Problem9
{
    class LongestCollatzSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Collatz Sequence");

            LongestCollatzSequence lcs = new LongestCollatzSequence();

            BigInteger goal = 1000000;

            BigInteger result = lcs.FindLongestCollatzSequence(goal);

            Console.WriteLine("Answer: " + result);

            Console.ReadKey();
        }

        public int FindLongestCollatzSequence(BigInteger goal)
        {
            int longestChain = 0;
            int answer = 0;

            while(goal > 0) 
            {   
                int chain = 0;
                BigInteger test = goal;
                int initialTest = (int) test;

                do
                {
                    if(test % 2 == 0)
                    {
                        test = test/2;
                    } else {
                        test = (3*test) + 1;
                    }
                    chain += 1;
                }
                while(test != 1);

                goal -= 1;

                if(longestChain < chain)
                {
                    longestChain = chain;
                    answer = initialTest; 
                }

            }
            return answer;
        }
    }
}
