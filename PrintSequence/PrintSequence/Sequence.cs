namespace PrintSequence
{
    using System;
    using System.Collections.Generic;

    public class Sequence
    {
        private Queue<int> elements = new Queue<int>();
        private int elementsCount = 1;
        private int n = 2;
        private int current;

        public void QueueTest()
        {
            elements.Enqueue(n);
            Console.Write(elements.Peek() + " ");

            do
            {
                current = elements.Dequeue();

                elements.Enqueue(current + 1);
                Console.Write((current + 1) + " ");

                elements.Enqueue(2 * current + 1);
                Console.Write((2 * current + 1) + " ");

                elements.Enqueue(current + 2);
                Console.Write((current + 2) + " ");


                elementsCount += 3;
            } while (elementsCount < 50);
            Console.WriteLine();
        }
    }
}
