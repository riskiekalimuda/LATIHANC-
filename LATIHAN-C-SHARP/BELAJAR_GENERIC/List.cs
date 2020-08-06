using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP.BELAJAR_GENERIC
{
    public class List
    {
        public void Add(int a)
        {
            throw new NotImplementedException();
        }
        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<Tkey, Tvalue>
    {
        public void add(Tkey key, Tvalue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void add(T value)
        {
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
