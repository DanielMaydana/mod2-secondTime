using Algorithms;
using Iterators;
using System;

namespace Lists
{
    public class GenericLinkedList<T> : IGenericList<T>
    {
        private uint size;
        private GenericRootElement<T> root;
        private delegate bool PRED(T obj);

        public GenericLinkedList()
        {
            this.size = 0;
            this.root = new GenericRootElement<T>();
            this.root.First = this.root.Last = null;
        }

        public void Add(T toAdd)
        {
            this.Insert(toAdd, this.size);
        }

        public void Clear()
        {
            while (this.size != 0)
            {
                this.Delete(0);
            }
        }

        public bool Contains(T toFind)
        {
            return TraverseUntil(toEval => toEval.Equals(toFind));
        }

        public void Delete(uint position)
        {
            this.ValidatePosition(position);

            GenericElement<T> elemToDel = this.GetElementFrom(position);

            if (this.size == 1 && position == 0)
            {
                this.root.First = this.root.Last = null;
                SetElementToNull(elemToDel);
            }
            else if ((this.size - 1) == position && this.size > 1)
            {
                this.root.Last = elemToDel.PrevElem;
                elemToDel.PrevElem.NextElem = null;
                SetElementToNull(elemToDel);
            }

            else if (this.size > 0 && position == 0)
            {
                this.root.First = elemToDel.NextElem;
                elemToDel.NextElem.PrevElem = null;
                SetElementToNull(elemToDel);
            }
            else if (this.size > position && position > 0)
            {
                GenericElement<T> prior = elemToDel.PrevElem;
                GenericElement<T> later = elemToDel.NextElem;

                prior.NextElem = later;
                later.PrevElem = prior;

                SetElementToNull(elemToDel);
            }

            this.size--;
        }

        public void Delete(T toDel)
        {
            int position = IndexOf(toDel);

            if (position > -1)
            {
                this.Delete((uint)position);
            }
            else
            {
                throw new ArgumentException("Object not found in Linked List.");
            }
        }

        private void SetElementToNull(GenericElement<T> toDelete)
        {
            toDelete.PrevElem = toDelete.NextElem = null;
        }

        public T Get(uint position)
        {
            this.ValidatePosition(position);

            return GetElementFrom(position).Value;
        }

        private bool TraverseUntil(PRED evaluation)
        {
            GenericElement<T> current = this.root.First;
            bool eval = false;

            while (current != null && !eval)
            {
                eval = evaluation(current.Value);
                current = current.NextElem;
            }

            return eval;
        }

        private GenericElement<T> GetElementFrom(uint position)
        {
            GenericElement<T> toReturn = this.root.First;

            uint index = 0;

            while (toReturn != null)
            {
                if (index == position) return toReturn;
                else
                {
                    index = index + 1;
                    toReturn = toReturn.NextElem;
                }
            }

            return toReturn;
        }

        public IIterator GetIterator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T toFind)
        {
            return GetIndexWhere(toEval => toEval.Equals(toFind));
        }

        private int GetIndexWhere(PRED evaluation)
        {
            GenericElement<T> current = this.root.First;
            bool eval = false;
            int index = 0;

            while (current != null && !eval)
            {
                eval = evaluation(current.Value);
                current = current.NextElem;
                index++;
            }

            return eval ? (index - 1) : -1;
        }

        public void Insert(T value, uint position)
        {
            this.ValidatePosition(position);

            GenericElement<T> elemToInsert = new GenericElement<T>(value);

            if (this.size == 0 && position == 0)
            {
                this.root.First = this.root.Last = elemToInsert;
            }
            else if (this.size == position && this.size > 0)
            {
                elemToInsert.PrevElem = this.root.Last;
                this.root.Last.NextElem = elemToInsert;
                this.root.Last = elemToInsert;
            }
            else if (this.size > 0 && position == 0)
            {
                elemToInsert.NextElem = this.root.First;
                this.root.First.PrevElem = elemToInsert;
                this.root.First = elemToInsert;
            }
            else if (this.size > position && position > 0)
            {
                GenericElement<T> later = this.root.First;
                uint index = 0;

                while (index < position)
                {
                    later = later.NextElem;
                    index++;
                }

                GenericElement<T> prior = later.PrevElem;

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
            if (position > this.size) throw new ArgumentException("Position is not valid.");
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void Set(T toSet, uint position)
        {
            this.ValidatePosition(position);

            GenericElement<T> current = this.GetElementFrom(position);

            current.Value = toSet;
        }

        public uint Size()
        {
            return this.size;
        }
    }
}
