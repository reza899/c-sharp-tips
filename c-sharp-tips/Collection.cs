using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_tips
{
    public class Collection
    {
        public Collection()
        {

        }
        public void Add(object o)
        {
            throw new Exception();
        }

        public int this[int index]
        {
            get { throw new Exception(); }
        }
    }

    public class GenericCol<T>
    {
        public string Add(T value)
        {
            return value.ToString();
        }
    }

    public class GenericDict<TKey, TValue>
    {
        public string Add(TKey key,TValue value)
        {
           return key.ToString() + value.ToString();
        }
    }


    public class Utilities<T> where T : struct, IComparable
    {
        public T Max(T a,T b)
        {
            return a.CompareTo(b)>0 ? a : b;
        }
    }

    public class Nullable<T> where T : struct
    {
        private readonly object value;

        public Nullable()
        {

        }
        public Nullable(T value)
        {
            this.value = value;
        }
        public bool HasValue
        {
            get { return value != null; }
        }

        public T ValueOrDefault()
        {
            if (HasValue)
                return (T)value;
            else
                return default(T);
        }
    }
}
