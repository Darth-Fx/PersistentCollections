using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentCollections.PersistentStack
{
    public class EmptyStack<T> : IStack<T>
    {
        public int Depth() => 0;
        

        public IStack<T> Pop() => throw new InvalidOperationException();

        public IStack<T> Push(T newTop) => new NonEmptyStack<T>(newTop, this);
        

        public T Top() => throw new InvalidOperationException();
        
    }
}
