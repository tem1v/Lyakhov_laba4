using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab4
{
    internal class Vector
    {
        public int[] array;    

        public int size;       

        public int capacity;   

        public Vector(int capacity)
        {
            this.array = new int[capacity];
            this.size = 0;
            this.capacity = capacity;
        }

        public void Fill(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Add(i);
            }
        }

        public int GetByIndex(int index)
        {
            return array[index];
        }

        public void SetByIndex(int index, int value)
        {
            array[index] = value;
        }

        public void Add(int element)
        {
            if (size == capacity)
            {
                int newCapacity = capacity * 2;
                int[] newArray = new int[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }
            array[size] = element;
            size++;
        }

        public void Delete()
        {
            size--;
        }

        public void Insert(int index, int element)
        {
            if (size == capacity)
            {
                int newCapacity = capacity * 2;
                int[] newArray = new int[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }

            for (int i = size - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = element;
            size++;
        }

        public int[] Max()
        {
            int maxIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return new int[] { maxIndex, array[maxIndex] };
        }

        public int Count()
        {
            return size;
        }
    }
}
