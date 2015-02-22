namespace LinkedQueue
{
    using System;
    using System.Collections.Generic;
    using LinkedQueue;

    public class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> numbers = new LinkedQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(i);
            }

            numbers.Enumerate();

            for (int i = 0; i < 7; i++)
            {
                numbers.Dequeue();
            }

            numbers.Enumerate();
        }
    }
}
