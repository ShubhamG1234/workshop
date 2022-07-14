using System;

namespace PrimeNumberProgram
{
   class Number
    {
        public static void Main(string[] args)
        {
            int n = 50, b = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    b++;
                }
            }
            if (b == 2) { Console.WriteLine("Number is Prime"); }
            else { Console.WriteLine("Number is not Prime"); }
        }
    }
}