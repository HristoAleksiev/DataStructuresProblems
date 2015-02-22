namespace RemoveOddAppearances
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 6, 6, 3, 3 };
            Remove remove = new Remove();

            remove.RemoveOddAppearances(numbers);

            foreach (var number in numbers)
	        {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
