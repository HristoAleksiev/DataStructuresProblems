namespace IncreasingOrderSort
{
    using System;
    using System.Collections.Generic;

    public class Sort
    {
        private List<int> numbers = new List<int>();

        public void GetNumbers()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (input != String.Empty)
                {
                    numbers.Add(int.Parse(input));
                }
                else
                {
                    return;
                }
            } while (true);
        }

        public void SortAscending()
        {
            numbers.Sort();
        }

        public void PrintNumbers()
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
