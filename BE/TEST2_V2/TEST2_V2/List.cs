using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public class List : IList
    {
        Element first;
        int size;

        public List()
        {
            first = new Element(null);
            size = 0;
        }


        public void Add(object toAdd)
        {
            var aux = new Element(toAdd);

            if(first.Next == null)
            {
                first.Next = aux;
            }
            else
            {
                var current = first.Next;

                while( current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = aux;
            }

            size++;
        }

        public void Delete(int pos)
        {
            var aux = first.Next;
            first.Next = aux.Next;
            aux.Next = null;
            size--;
        }

        public object Get(int pos)
        {
            return first.Next.Value;
        }

        public int Size()
        {
            return size;
        }
    }
}
