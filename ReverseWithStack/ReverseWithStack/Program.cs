namespace ReverseWithStack
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            ReverseIntegers numbers = new ReverseIntegers();

            numbers.ReadNumbers();
            numbers.PrintStackReversed();
        }
    }
}
