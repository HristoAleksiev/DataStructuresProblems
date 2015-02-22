namespace Majorant
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 3, 3, 3, 2, 3, 4, 3, 3 };
            FindMajorant majorant = new FindMajorant();
            int theMajorant;

            theMajorant = majorant.FindMajorantOf(numbers);
            Console.WriteLine(theMajorant);
        }
    }
}
