namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>() { 1, 2, 2, 2, 3, 3, 4, 4, 5, 5, 5, 5, 5, 3, 4, 4 };
            List<int> longest;

            FindLongestSubsequence numbers = new FindLongestSubsequence();

            longest = numbers.ReturnLongestSubsequence(numbersList);

            foreach (var number in longest)
            {
                Console.WriteLine(number);
            }
        }
    }
}
