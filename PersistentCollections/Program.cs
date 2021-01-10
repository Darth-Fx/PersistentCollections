using PersistentCollections.PersistentStack;
using System;

namespace PersistentCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> emptyStack = new EmptyStack<int>();
            IStack<int> persistentStack = emptyStack.Push(12)
                            .Push(2)
                            .Push(3);

            while (persistentStack.Depth() != 0)
            {
                Console.WriteLine($"pop: {persistentStack.Top()}");
                persistentStack = persistentStack.Pop();
            }
        }          
    }
}
