using Algorithms;
using System;

namespace Lists
{
    public class LinkedList : IList
    {
        private uint size;
        private RootElement root;

        public LinkedList()
        {
            this.size = 0;
            this.root = new RootElement();
            this.root.First = this.root.Last = null;
        }

        public void Add(object toAdd)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object toAdd)
        {
            throw new NotImplementedException();
        }

        public void Delete(uint index)
        {
            throw new NotImplementedException();
        }

        public void Delete(object toDel)
        {
            throw new NotImplementedException();
        }

        public object Get(uint position)
        {
            ValidatePosition(position);
            return GoForward(position).Value;
        }

        private Element GoForward(uint position)
        {
            Element toReturn = this.root.First;
            uint index = 0;

            while (toReturn.NextElem != null)
            {
                if (index == position) break;
                else toReturn = toReturn.NextElem;
            }

            Console.WriteLine("TO RET: {0}", toReturn.Value);

            return toReturn;
        }

        public IIterator GetIterator()
        {
            throw new NotImplementedException();
        }

        public uint IndexOf(object toInsert)
        {
            throw new NotImplementedException();
        }

        public void Insert(object value, uint position)
        {
            ValidatePosition(position);

            Element elemToInsert = new Element(value);

            if (this.size == 0 && position == 0)
            {
                this.root.First = this.root.Last = elemToInsert;
            }
            if (this.size == position && this.size > 0)
            {
                elemToInsert.PrevElem = this.root.Last;
                this.root.Last.NextElem = elemToInsert;
                this.root.Last = elemToInsert;
            }
            if (this.size > 0 && position == 0)
            {
                elemToInsert.NextElem = this.root.First;
                this.root.First.PrevElem = elemToInsert;
                this.root.First = elemToInsert;
            }
            if (this.size > position && position > 0)
            {
                Element later = this.root.First;
                uint index = 0;

                while (index < position)
                {
                    later = later.NextElem;
                    index++;
                }

                Element prior = later.PrevElem;

                prior.NextElem = elemToInsert;
                later.PrevElem = elemToInsert;
                elemToInsert.PrevElem = prior;
                elemToInsert.NextElem = later;
            }

            this.size++;
        }

        public void Show()
        {
            var aux = this.root.First;

            while (aux != null)
            {
                Console.WriteLine("value {0}", aux.Value);
                aux = aux.NextElem;
            }
        }

        public void ShowReverse()
        {
            var aux = this.root.Last;

            while (aux != null)
            {
                Console.WriteLine("value {0}", aux.Value);
                aux = aux.PrevElem;
            }
        }

        private void ValidatePosition(uint position)
        {
            if (position > this.size) throw new IndexOutOfRangeException();
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void Set(object toInsert, uint position)
        {
            throw new NotImplementedException();
        }

        public uint Size()
        {
            return this.size;
        }
    }
}