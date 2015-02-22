namespace SumAndAverage
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            operations.ReadNumbers();
            Console.WriteLine(operations.ToString());
        }
    }
}
