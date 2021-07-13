using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,V>
    
        {
        T[] items;
        V[] values;
        //constructor 
        public MyDictionary()
        {
            items = new T[0];
            values = new V[0];
        }
        public void Add(T item,V value)
        {
            T[] tempArrayKey = items;
            V[] tempArrayValue = values;
            items = new T[items.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                items[i] = tempArrayKey[i];
                values[i] = tempArrayValue[i];
            }
            items[items.Length - 1] = item;
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return items.Length; }
        }

        public void WriteConsoleListValue()
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        public void WriteConsoleListKey()
        {
            foreach (var key in items)
            {
                Console.WriteLine(key);
            }
        }
    }
}
    

