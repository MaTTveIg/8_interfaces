using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_interfaces
{
    internal class StackCustom : IReport
    {
        private static int size = 100;
        private int[] arr = new int[size];
        private int top = 0;
        private int capasity = size;

        public void Push(int number)
        {
            if (isFull())
                Console.WriteLine("Stack is full");
            arr[++top] = number;
            Console.WriteLine("Number " + number + " was insert");
        }
        public int Pop()
        {
            if (isEmpty())
            {
                System.Environment.Exit(0);
                Console.WriteLine("Stack is full");
            }
            else Console.WriteLine("Removed " + Peek());
            return arr[--top];
        }
        public int Peek()
        {
            if (!isEmpty())
                return arr[top];
            else System.Environment.Exit(0); Console.WriteLine("ERROR"); return 0;
        }
        public int Count() => top;
        public bool isFull() => top == capasity - 1;
        public bool isEmpty() => top == -1;

        public void ShowEven()
        {
            for (int i = 0; i < size; ++i)
            {
                if (arr[i] % 2 == 0 && arr[i] != 0)
                    Console.Write(arr[i] + " ");
            }
        }
        public void ShowOdd()
        {
            for (int i = 0; i < size; ++i)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}

