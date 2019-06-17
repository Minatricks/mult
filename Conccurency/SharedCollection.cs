using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
namespace Conccurency
{
    //o	users can only read from it
    //If you are only reading from a shared collection, then you can use the classes in the System.Collections.Generic namespace.
    //We recommend that you do not use 1.0 collection classes unless you are required to target the.NET Framework 1.1 or earlier runtime.
    public class SharedCollection
    {
        public List<string> _values = new List<string>() { "1", "2", "2", "4" };

        public string this[int index]
        {
            get { return _values[index]; }
        }


    }
    //o users can read and modify it 
    //o	users can only operate with items in collection
    //The.NET Framework 4 introduces the System.Collections.Concurrent namespace, which includes several collection classes that are both thread-safe and scalable.
    //  Multiple threads can safely and efficiently add or remove items from these collections, without requiring additional synchronization in user code.


    //https://docs.microsoft.com/ru-ru/dotnet/standard/collections/thread-safe/


}
