namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class RemoveNumbers
    {
        public void RemoveNegativenumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }
        }
    }
}
