using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public class BasicQueue : IQueue
    {
        List list;

        public BasicQueue()
        {
            list = new List();
        }

        public object Dequeue()
        {
            var aux = list.Get(0);
            list.Delete(0);
            return aux;
        }

        public void Enqueue(object toEnq)
        {
            list.Add(toEnq);
        }

        public bool isEmpty()
        {
            return list.Size() == 0;
        }
    }
}
