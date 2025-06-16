using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    internal class MyList
    {
        private ArrayList items = new ArrayList();

        public int Count => items.Count;

        public void Add(object item)
        {
            items.Add(item);
        }

        public void Remove(object item)
        {
            items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public void Clear()
        {
            items.Clear();
        }

        public object this[int index]
        {
            get { return items[index]; }
        }
    }
}
