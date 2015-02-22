namespace RemoveOddAppearances
{
    using System;
    using System.Collections.Generic;

    public class Remove
    {
        private List<int> numbersWorkCopy = new List<int>();

        public void RemoveOddAppearances(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                numbersWorkCopy.Add(numbers[i]);
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            numbersWorkCopy.Add(numbers[j]);
                        }
                    }
                }
                if (numbersWorkCopy.Count % 2 != 0)
                {
                    numbers.RemoveAll(item => item == numbersWorkCopy[0]);
                }
                numbersWorkCopy.Clear();
            }
        }
    }
}
