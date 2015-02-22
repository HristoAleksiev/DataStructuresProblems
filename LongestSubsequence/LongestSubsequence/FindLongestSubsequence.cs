namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class FindLongestSubsequence
    {
        public List<int> ReturnLongestSubsequence(List<int> numbers)
        {
            List<int> longestSubseq = new List<int>();
            ushort longestStreak = ushort.MinValue;
            ushort currentStreak = 1;
            int longestStreakValue = 0;
            
            //  Main loop; iterates through "numbers" from the second element to the end 
            for (int i = 1; i < numbers.Count; i++)
            {
                // compares each number with its anterior
                if (numbers[i] == numbers[i - 1])
                {
                    currentStreak++;
                    //  checks if the current subsequence is the largest
                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                        longestStreakValue = numbers[i];
                    }
                }
                else
                {
                    currentStreak = 1;
                }
            }

            //  fill the separate List<int> with the largest subsequence
            for (int i = 0; i < longestStreak; i++)
            {
                longestSubseq.Add(longestStreakValue);
            }
            return longestSubseq;
        }
    }
}
