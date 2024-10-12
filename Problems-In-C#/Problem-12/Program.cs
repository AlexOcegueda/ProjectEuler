using System;

namespace ProjectEuler.Problems.Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangular Numbers");

            Program tn = new Program();
            int goal = 500;  // Goal for minimum divisors
            int result = tn.FindTriangularNumberDivisors(goal);

            Console.WriteLine("Answer: " + result);
        }

        public int FindTriangularNumberDivisors(int goal)
        {
            int t = 0;
            int step = 1;
            int divisors = 0;

            while (divisors < goal)
            {
                t += step;
                step++;

                divisors = findDivisors(t);
                Console.WriteLine($"Checking t = {t}, divisors = {divisors}");
            }
            return t;
        }

        public int findDivisors(int num)
        {
            int limit = (int)Math.Sqrt(num);
            int divisors = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (num % i == 0)
                {
                    if (i != num / i)
                    {
                        divisors += 2;
                    }
                    else
                    {
                        divisors += 1;
                    }
                }
            }
            return divisors;
        }
    }
}
