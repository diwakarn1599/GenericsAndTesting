using System;

namespace GenericsAndTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics and testing");
            int[] array = { 6, 4, 3, 2, 1 };
            MaxOfThree<int> findMaxArray = new MaxOfThree<int>(array);
            findMaxArray.FindMaxOfArray();
        }
    }
}
