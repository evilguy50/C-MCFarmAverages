using System;

namespace FarmAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            string Drops = "How many drops did your farm get from your afk session?";
            Console.WriteLine(Drops);
            double drops = Convert.ToDouble(Console.ReadLine());
            string Hours = "How many hours were you afk?";
            Console.WriteLine(Hours);
            double hours = Convert.ToDouble(Console.ReadLine());
            double result = drops / hours;
            Console.WriteLine("Your farm produced an average of " + result + " drops per hour.");
            Console.WriteLine("Press any key to exit program:");
            Console.ReadKey();
        }
    }
}
