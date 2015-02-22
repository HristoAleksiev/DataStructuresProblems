namespace OccurenceCounter
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2, 6, 6, 3, 3, 3, 3, 3 };
            Occurences occurences = new Occurences();

            occurences.FindOccurences(numbers);
        }
    }
}
