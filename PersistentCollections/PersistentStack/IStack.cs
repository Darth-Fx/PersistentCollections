using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentCollections.PersistentStack
{
    /*
     * Immutable Collection based upon Git concept, which prevent copying a complete immutable collection everytime
     * we push or pop some value T
     * Either T must be a type whose instances are immutable , or only instances that will remain immutable may be pushed.
    */
    public interface IStack<T> 
    {
        int Depth();
        T Top();
        IStack<T> Pop();
        IStack<T> Push(T newTop);
    }
}
