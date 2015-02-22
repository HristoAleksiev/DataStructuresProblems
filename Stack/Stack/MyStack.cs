namespace Stack
{
    using System;
    using System.Collections.Generic;

    public class MyStackElement<T>
    {
        public T value;
        public int position;
        public MyStackElement<T> Previous {get; set;}
    }

    public class MyStack<T>
    {
        private static int size = 5;
        private int position = 0;
        private MyStackElement<T>[] content = new MyStackElement<T>[size];

        public void Push(T value)
        {
            MyStackElement<T> elementToAdd = new MyStackElement<T>() { value = value};

            if (position == content.Length - 1)
            {
                content = CopyArray(content);
            }

            if (content[0] == null)
            {
                content[0] = elementToAdd;
                content[0].position = 0;
                position++;
            }
            else
            {
                content[position] = elementToAdd;
                position++;
            }
        }

        public MyStackElement<T>[] CopyArray(MyStackElement<T>[] arr)
        {
            size = size * 2;
            MyStackElement<T>[] toReturn = new MyStackElement<T>[size];

            for (int i = 0; i < arr.Length; i++)
            {
                toReturn[i] = arr[i];
            }

            return toReturn;
        }

        public T Pop()
        {
            MyStackElement<T> toReturn = content[position - 1];
            position--;
            return toReturn.value;
        }
    }
}
