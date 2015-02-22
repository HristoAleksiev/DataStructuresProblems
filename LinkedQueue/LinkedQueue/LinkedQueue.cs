namespace LinkedQueue
{
    using System;
    using System.Collections.Generic;

    public class LinkedQueueElement<T>
    {
        public T value;
        public LinkedQueueElement<T> Previous { get; set; }
        public LinkedQueueElement<T> Next { get; set; }
    }

    public class LinkedQueue<T>
    {
        private LinkedQueueElement<T> Head { get; set; }
        private LinkedQueueElement<T> Tail { get; set; }

        public void Enqueue(T value)
        {
            LinkedQueueElement<T> elemenToAdd = new LinkedQueueElement<T>() { value = value };

            if (this.Head == null)
            {
                this.Head = elemenToAdd;
                this.Tail = elemenToAdd;
            }
            else
            {
                this.Tail.Next = elemenToAdd;
                elemenToAdd.Previous = this.Tail;
                this.Tail = elemenToAdd;
            }
        }

        public void Dequeue()
        {
            this.Head = this.Head.Next;
        }

        public void Enumerate()
        {
            LinkedQueueElement<T> toPrint = this.Head;

            while (toPrint != null)
            {
                Console.Write(toPrint.value + " ");
                toPrint = toPrint.Next;
            }
            Console.WriteLine();
        }
    }
}
