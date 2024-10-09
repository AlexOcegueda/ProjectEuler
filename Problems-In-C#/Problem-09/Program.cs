using System;
using System.Numerics;

namespace ProjectEuler.Problems.Problem9
{
    class SpecialPythagoreanTriplet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Special Pythagorean Triplet");

            SpecialPythagoreanTriplet spt = new SpecialPythagoreanTriplet();

            BigInteger goal = 1000;

            BigInteger result = spt.FindSpecialPythagoreanTriplet(goal);

            Console.WriteLine("Answer: " + result);

            Console.ReadKey();
        }

        public BigInteger FindSpecialPythagoreanTriplet(BigInteger goal)
        {
            BigInteger a = 0;
            BigInteger b = 0;
            BigInteger c = 0;

            for (a = 1; a <= goal; a++) {
                for (b = a + 1; b <= goal; b++) {
                    c = goal - a - b;

                    // checks if it's a right triangle
                    if ((a*a) + (b*b) == (c*c))
                    {
                        
                        if (a + b + c == goal)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                        return a*b*c;
                    }
                }
            }

            return 0;
        }
    }
}
