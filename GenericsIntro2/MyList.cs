using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro2
{
    internal class MyList<T>
    {
        T[] items;
        //constuructor
        public MyList() //ctor kısa yolu
        {
                items = new T[0];
        }

        internal void Add(T item)
            
        {
            T[] tempArry = items;

            items = new T[items.Length+1];

            for (int i = 0; i < tempArry.Length; i++)
            {
                items[i] = tempArry[i]; 

            }

            items[items.Length] = item; 
            
        }
    }
}
