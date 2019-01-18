using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQInManhattan.Classes
{
    public class RootObject : IList
    {

        public string type { get; set; }
        public List<Feature> features { get; set; }

        public int Add(object value)
        {
            // Was unable to figure out what exactly to do here. Would adding an object result in an addition to the List<Feature> or would I need to create a new array to hold the objects?
            throw new NotImplementedException();
        }


        // Not utilizing these interface properties and methods
        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsFixedSize => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();
        public int Count => throw new NotImplementedException();
        public bool IsSynchronized => throw new NotImplementedException();
        public object SyncRoot => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
