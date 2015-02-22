namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, -2, 2, 3, -3, 4, 4, -5, -5, 5, -5, -5, -3, 4, 4 };
            RemoveNumbers remove = new RemoveNumbers();

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            remove.RemoveNegativenumbers(numbers);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
