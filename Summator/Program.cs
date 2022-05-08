using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Summator summator = new Summator();

            double sum = summator.Sum(new double[] { 1.2, 2, 3, 4, 5, 6 });

            if (sum == 21.2)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            double average = Summator.Average(new double[] { 5, 10, 15 });

            if (average == 10)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }
    }
}
