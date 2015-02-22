namespace IncreasingOrderSort
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            Sort numbers = new Sort();

            numbers.GetNumbers();
            numbers.SortAscending();
            numbers.PrintNumbers();
        }
    }
}
