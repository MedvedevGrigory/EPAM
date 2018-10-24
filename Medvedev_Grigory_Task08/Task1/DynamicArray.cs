using System;

namespace Task1
{
    class DynamicArray<T> where T : new()
    {
        T[] array;

        public int Capacity { get => array.Length; }

        int length;
        public int Length { get => length; }

        public DynamicArray(int size)
        {
            if (size < 0)
            {
                throw new IndexOutOfRangeException();
            }
            array = new T[size];
            length = 0;
        }

        public DynamicArray() : this(8)
        {
        }

        public DynamicArray(T[] arr) : this(arr.Length)
        {
            array = arr;
        }

        public void Add(T newElement)
        {
            if (length == Capacity)
            {
                changeSize();
            }
            array[length++] = newElement;
        }

        public void AddRange(T[] arr)
        {
            if (Capacity - length < arr.Length)
            {
                changeSize(arr.Length + length);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                array[length++] = arr[i];
            }
        }

        public bool Remove(T value)
        {
            int index = Array.IndexOf(array, value);
            if (index == -1)
            {
                return false;
            }

            for (int i = index; i < length; i++)
            {
                array[i] = array[i + 1];
            }
            length--;

            return true;
        }

        public void Insert(T value, int index)
        {
            checkIndex(index);
            if (length == Capacity)
            {
                changeSize();
            }

            for (int i = index; i < length; i++)
            {
                array[i + 1] = array[i];
            }
            array[index] = value;
            length++;
        }

        void changeSize()
        {
            T[] newArray = new T[length * 2];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        void changeSize(int count)
        {
            T[] newArray = new T[count];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        void checkIndex(int index)
        {
            if (index > length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
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
