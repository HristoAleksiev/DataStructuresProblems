namespace Majorant
{
    using System;
    using System.Collections.Generic;

    public class FindMajorant
    {
        private int occurences = 1;
        private int majorantOccurences;
        private int majorant;

        public int FindMajorantOf(List<int> numbers)
        {
            majorantOccurences = numbers.Count / 2 + 1;
            do
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[0] == numbers[i])
                    {
                        occurences++;
                        numbers.RemoveAt(i);
                        i--;
                    }
                }
                if (occurences >= majorantOccurences)
                {
                    majorant = numbers[0];
                }
                numbers.RemoveAt(0);
                occurences = 1;
            } while (numbers.Count != 0);

            return majorant;
        }
    }
}
