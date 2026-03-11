namespace SampleConsoleApp
{
    public class Program
    {
        public static int Fact(int number)
        {
            if (number == 0) { return 1; }
            return number * Fact(number - 1);
        }

        public static void Main()
        {
            Console.WriteLine(Fact(10));
            Console.WriteLine("The quick brown fox jumps over the lazy dog");
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        
    }
}