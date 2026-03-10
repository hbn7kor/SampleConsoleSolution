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
    }
}

