using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1000_digit_Fibonacci_number
{
    //What is the first term in the Fibonacci sequence to contain 1000 digits?
    class Program
    {
        private static IEnumerable<BigInteger> FibSequence()
        {
            BigInteger x = 0;
            BigInteger y = 1;

            while (true)
            {
                BigInteger temp = y;
                y = x + y;
                x = temp;

                yield return x;
            }
        }

        static void Main(string[] args)
        {
            var positionOfTerm = FibSequence().TakeWhile(i => i.ToString().Length < 1000).Count() + 1;

            Console.WriteLine(positionOfTerm);
            Console.ReadLine();
        }
    }
}
