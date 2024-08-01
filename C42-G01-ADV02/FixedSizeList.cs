using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV02
{
    internal class FixedSizeList<T>
    {
        private T[] FixedList;
        private int Count;
        public FixedSizeList(int capacity)
        {
            FixedList = new T[capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count >= FixedList.Length)
            {
                throw new Exception("List is full");
            }
            FixedList[Count] = item;
            Count++;
        }

        public T Get(int index)
        {
            if (index >= Count)
            {
                throw new Exception("Invalid index.");
            }
            return FixedList[index];
        }
    }
}
