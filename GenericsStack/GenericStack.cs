using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStack
{
    internal class GenericStack<T>
    {
        // Constants
        private const int SIZE = 15;

        // Fields
        private int top;
        private T[] data;

        // Property to check if stack is empty
        public bool IsEmpty => top == -1;

        // Property to get the top index
        public int TopIndex => top;

        // Constructor
        public GenericStack()
        {
            data = new T[SIZE];
            top = -1;
        }

        // Push method to add item to the top of the stack
        public void Push(T item)
        {
            if (top >= SIZE - 1)
                throw new InvalidOperationException("Stack is full.");

            top++;
            data[top] = item;
        }

        // Pop method to remove and return the top item
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty.");

            T item = data[top];
            top--;
            return item;
        }

        // Gets item at a specific index (used for display)
        public T GetItemAt(int index)
        {
            if (index < 0 || index > top)
                throw new IndexOutOfRangeException("Index out of range.");

            return data[index];
        }
    }
}
