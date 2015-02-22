namespace SumAndAverage
{
    using System;
    using System.Collections.Generic;

    public class Operations
    {
        private List<int> numbers = new List<int>();

        public void ReadNumbers()
        {
            do
            {
                string input = Console.ReadLine();
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

        public int Average()
        {
            if (numbers.Count != 0)
            {
                return Sum() / numbers.Count;
            }
            else
            {
                return 0;
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public override string ToString()
        {
            string stringReturn = string.Format(
                "This is the sum of all the numbers you have entered:   " +
                Sum() +
                ";\n" + "and this is the average of all of them:   " +
                Average() + "!");
            return stringReturn;
        }
    }
}
