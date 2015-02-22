namespace DataStructures
{
    using System;
    using System.Collections.Generic;

    public class LinkedListItem<T>
    {
        public T value { get; set; }
        public LinkedListItem<T> Previous { get; set; }
        public LinkedListItem<T> Next { get; set; }
    }

    public class MyLinkedList<T> : IEnumerable<T>
    {
        private LinkedListItem<T> Start { get; set; }
        private LinkedListItem<T> End { get; set; }

        //  Add methods 
        public void Add(T itemValue)
        {
            LinkedListItem<T> newItem = new LinkedListItem<T>() { value = itemValue };

            if (Start == null)
            {
                this.Start = newItem;
                this.End = newItem;
            }
            else
            {
                this.End.Next = newItem;
                newItem.Previous = this.End;
                this.End = newItem;
            }
        }

        //  Custom enumerator
        public void Enumerate()
        {
            LinkedListItem<T> itemToPrint = this.Start;
            
            while (itemToPrint != null)
            {
                if (itemToPrint.Next == null)
                {
                    Console.WriteLine(itemToPrint.value + ".");
                }
                else
                {
                    Console.Write(itemToPrint.value + ", ");
                }
                itemToPrint = itemToPrint.Next;
            }
        }

        //  IEnumerator implementation 
        public IEnumerator<T> GetEnumerator()
        {
            LinkedListItem<T> item = this.Start;

            while (item != null)
            {
                yield return item.value;
                item = item.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
