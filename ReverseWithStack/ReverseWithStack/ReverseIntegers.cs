namespace ReverseWithStack
{
    using System;
    using System.Collections.Generic;

    public class ReverseIntegers
    {
        private Stack<int> numbers = new Stack<int>();

        public void ReadNumbers()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (input != String.Empty)
                {
                    numbers.Push(int.Parse(input));
                }
                else
                {
                    return;
                }
            } while (true);
        }

        public void PrintStackReversed()
        {
            do
            {
                Console.WriteLine(numbers.Pop());
            } while (numbers.Count != 0);
        }
    }
}
