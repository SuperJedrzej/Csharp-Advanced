﻿using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {

        }
        public Book this[int index]
        {
              get { throw new NotImplementedException(); }
        }
    }

    public class ObjectList
    {
        public void Add(object value)
        {

        }

        public object this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
