using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T> : IEnumerable<T>
    {
        T[] data;
        int count;
        int capacity;
        string list1;
        string list2;
        string list3;

        public CustomList()
        {
            capacity = 100;
            data = new T[capacity];
            count = 0;
        }
        //constructor
        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set 
            {
                data[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T item)
        {
            data[count] = item;
            if (count < 100)
            {
                count++;
            }
            else if (count > 100)
            {             
                DoubleArraySize();
            }
        }
        public void DoubleArraySize()
        {
            if (count * 2 >= capacity)
            {
                TransferToArray();
            }
            else if (count * 2 <= capacity)
            { 
            }
        }
        public void TransferToArray()
        {
            data = new T[capacity];
        }
        public bool Remove(T item)
        {
            //need to have a way to search for items
            //need to run Transfer to Array
        }
        public override string ToString()
        {
            return base.ToString() + ": " + data.ToString();
        }
        public IEnumerator<T> GetEnumerator()
        {
            //this needs to be edited
            foreach (T in data)
            {
                yield return T;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            //figure out how to add all contents
            list3 = list1 + list2;
            return list3;

        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            //figure out how to add all contents
            list3 = list1 + list2;
            return list3;
        }
    }
}
