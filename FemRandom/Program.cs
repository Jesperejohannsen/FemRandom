
namespace RandomGenerator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(1,11));
            }

            Console.ReadLine();
        }
    }
}