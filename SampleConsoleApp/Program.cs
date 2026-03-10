namespace SampleConsoleApp
{
    public class Master
    {

        public static int GetRandomNumber()
        {
            return new Random().Next(1, 100);
        }

        public static void Main()
        {
            int number = GetRandomNumber();
            if (number > 10)
            {
                Console.WriteLine("number > 10");
            }
            else
            {
                Console.WriteLine("number < 10");
            }
        }
    }
}