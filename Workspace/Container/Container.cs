using System;
using System.Collections;
using System.Collections.Generic;

namespace ModelX.Workspace{

    public class Container<T> : IList<T>, IList where T : Blank, new()
    {
        private List<T> list = new ();

        public Container()
        {   
            T? _item = new T();
            string containerName = Enum.GetName(typeof(BlankType), _item.Type) ?? string.Empty;
            ID = new ContainerID(containerName);
        }

        public string? Name {get; set;}

        public ContainerID ID { get; set; }
    
        public T this[int index] { get => list[index]; set => list[index] = value; }
        object? IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => list.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(T item)
        {
            list.Add(item);
        }

        public int Add(object? value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public bool Contains(object? value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public int IndexOf(object? value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            list. Insert(index, item);
        }

        public void Insert(int index, object? value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void Remove(object? value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}