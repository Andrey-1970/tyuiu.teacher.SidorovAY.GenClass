using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.teacher.SidorovAY.GenClass
{
    public class MyList<T> where T : IComparable<T>
    {
        private const int increment = 10;
        private T[] items = new T[0];
        private int inLen = 0;
        private int len = 0;
        public void Add(T item)
        {
            if (inLen == len)
            {
                inLen += increment;
                T[] newItems = new T[inLen];
                items.CopyTo(newItems, 0);
                items = newItems;
            }
            items[len] = item;
            len++;
        }
        public T GetItem(int index)
        {
            return items[index];
        }
        public T this[int key]
        {
            get => items[key];
        }
        public int Length => len;
        public int IndexOf(T value)
        {
            for (int i = 0; i < len; i++)
            {
                if (items[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
