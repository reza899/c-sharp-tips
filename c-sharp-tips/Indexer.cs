using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tips
{
    public class Indexer<T>
    {
        T[] list = new T[100];

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
    }
}
