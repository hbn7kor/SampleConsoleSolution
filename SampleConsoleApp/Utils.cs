using System;

namespace SampleConsoleApp
{
    public class Utils
    {
        public Utils()
        {
        }

        public static int Fact(int number)
        {
            if (number == 0) { return 1; }
            return (number * Fact(number - 1));
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) { return false; }
            for (int index = 2; index <= (int)Math.Sqrt(number); index++)
            {
                if (number % index == 0) { return false; }
            }
            return true;
        }
    }
}

