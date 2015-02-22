namespace ReverseWithStack
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            ReverseIntegers numbers = new ReverseIntegers();

            numbers.ReadNumbers();
            numbers.PrintStackReversed();
        }
    }
}
