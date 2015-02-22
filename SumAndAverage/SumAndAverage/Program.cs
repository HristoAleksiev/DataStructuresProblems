namespace SumAndAverage
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            operations.ReadNumbers();
            Console.WriteLine(operations.ToString());

            //Console.WriteLine(operations.Sum());
            //Console.WriteLine(operations.Average());
        }
    }
}
