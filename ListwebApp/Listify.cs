﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListwebApp
{
    public  class Listify:IList<int>
    {
        private int begin;
        private int end;
        public Listify(int begin, int end)
        {
            this.begin = begin;
            this.end = end;
        }
       

        public int this[int i]
        {
            get { return begin + i; }
            
        }

        int IList<int>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
