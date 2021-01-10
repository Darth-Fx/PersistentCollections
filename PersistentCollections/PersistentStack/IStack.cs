using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentCollections.PersistentStack
{
    //Collection based upon Git structure, which prevent copying a complete collection everytime we push or pop some value T
    //T must be Immutable valuetype for the collection to be immutable!
    public interface IStack<T> 
    {
        int Depth();
        T Top();
        IStack<T> Pop();
        IStack<T> Push(T newTop);
    }
}
