using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<T>
    {
        T[] items;
        //T[] tempItem;
        public MyDictionary() 
        {
            items= new T[0];

        }
        public void Add(T data)
        {
            T[] tempItem = items;
            items=new T[items.Length+1];
            for (int i = 0; i < tempItem.Length; i++)
            {
                items[i] = tempItem[i];
            }
            items[items.Length-1] = data;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}
