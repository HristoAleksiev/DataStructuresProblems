namespace Stack
{
    using System;
    using System.Collections.Generic;
    using Stack;

    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> numbers = new MyStack<int>();


            for (int i = 0; i < 10; i++)
            {
                numbers.Push(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
