using Algorithms;
using System;
using System.Collections.Generic;

namespace Iterators
{
    public class FilterIterator : IIterator
    {
        private IIterator iterator;
        private IPredicate predicate;
        private object first;
        private object last;

        public FilterIterator(IIterator iterator, IPredicate predicate)
        {
            this.iterator = iterator;
            this.predicate = predicate;
            this.SaveBorderPositions();
            this.First();
        }

        public void First()
        {
            this.iterator.First();
            this.GoNext();
        }

        public void Last()
        {
            this.iterator.Last();
            this.GoPrevious();
        }

        private void GoNext()
        {
            while (!this.predicate.Evaluate(this.iterator.Current()))
            {
                this.iterator.Next();
            }
        }

        private void GoPrevious()
        {
            while (!this.predicate.Evaluate(this.iterator.Current()))
            {
                this.iterator.Previous();
            }
        }

        public object Current()
        {
            return this.iterator.Current();
        }

        public void Next()
        {
            this.iterator.Next();
            this.GoNext();
        }

        public void Previous()
        {
            this.iterator.Previous();
            this.GoPrevious();
        }

        public bool IsDone()
        {
            return this.iterator.Current() == this.first || this.iterator.Current() == this.last;
        }

        private void SaveBorderPositions()
        {
            this.Last();
            this.last = this.iterator.Current();
            this.First();
            this.first = this.iterator.Current();
        }
    }
}
