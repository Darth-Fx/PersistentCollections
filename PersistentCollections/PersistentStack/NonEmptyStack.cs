using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentCollections.PersistentStack
{
    public class NonEmptyStack<T> : IStack<T>
    {
        private readonly T top;
        private readonly IStack<T> tail;

        public NonEmptyStack(T newTop, IStack<T> previous)
        {
            top = newTop;
            tail = previous;
        }
        public int Depth() => 1 + tail.Depth();

        public IStack<T> Pop() => tail;

        public IStack<T> Push(T newTop) => new NonEmptyStack<T>(newTop, this);


        public T Top() => top;
    }
}
