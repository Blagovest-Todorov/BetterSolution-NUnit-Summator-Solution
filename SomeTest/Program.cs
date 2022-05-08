using System;

namespace SomeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] someArr = new int[] { 1, 2, 3, 4, 5 };
            int[] subArr1 = someArr[0..^2];
            int[] subArr2 = someArr[1..^0];

            Console.WriteLine(String.Join(", ", subArr1));
            Console.WriteLine(String.Join(", ", subArr2));
        }
    }
}
