namespace LinkedList
{
    using System;
    using System.Collections.Generic;
    using DataStructures;

    public class TestLists
    {
        public static void Main()
        {
            MyLinkedList<int> numbers = new MyLinkedList<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
            }

            numbers.Enumerate();
        }
    }
}
