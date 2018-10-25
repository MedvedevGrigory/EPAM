using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class DynamicArray<T> : IEnumerable<T> where T : new()
    {
        T[] array;

        public int Capacity => array.Length;

        public int Length { get; private set; }

        public DynamicArray(int size)
        {
            if (size < 0)
            {
                throw new IndexOutOfRangeException();
            }
            array = new T[size];
            Length = 0;
        }

        public DynamicArray() : this(8)
        {
        }

        public DynamicArray(T[] arr) : this(arr.Length)
        {
            array = (T[])arr.Clone();
        }

        public DynamicArray(IEnumerable<T> arr) : this()
        {
            foreach (T item in arr)
            {
                Insert(item, Length);
            }
        }

        public void AddRange(T[] arr)
        {
            if (Capacity - Length < arr.Length)
            {
                changeSize(arr.Length + Length);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                array[Length++] = arr[i];
            }
        }

        public bool Remove(T value)
        {
            int index = Array.IndexOf(array, value);
            if (index == -1)
            {
                return false;
            }

            for (int i = index; i < Length; i++)
            {
                array[i] = array[i + 1];
            }
            Length--;

            return true;
        }

        public void Add(T newElement)
        {
            Insert(newElement, Length);
        }

        public void Insert(T value, int index)
        {
            checkIndex(index);
            if (Length == Capacity)
            {
                changeSize();
            }

            for (int i = index; i < Length; i++)
            {
                array[i + 1] = array[i];
            }
            array[index] = value;
            Length++;
        }

        void changeSize()
        {
            changeSize(Length * 2);
        }

        void changeSize(int count)
        {
            T[] newArray = new T[count];
            for (int i = 0; i < Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        void checkIndex(int index)
        {
            if (index > Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                checkIndex(index);
                return array[index];
            }
            set
            {
                checkIndex(index);
                array[index] = value;
            }
        }
    }
}
