namespace OccurenceCounter
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Occurences
    {
        private StringBuilder builder = new StringBuilder();
        private List<int> occurencesList = new List<int>();
        private int occurences = 1;

        public void FindOccurences(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        occurences++;
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
                occurencesList.Add(occurences);
                occurences = 1;
                builder.Append("Number " + numbers[i] + " appears " + occurencesList[i] + " times! \n");
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
