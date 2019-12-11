using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StandardList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //var x = myList.GetEnumerator();

            //bool eval = true;

            //while (eval)
            //{
            //    Console.WriteLine(x.Current);
            //    eval = x.MoveNext();
            //}

            //string[] strArr = new string[] { "wiser", "time", "black", "crowes" };

            //var y = strArr.GetEnumerator();
            //bool eval2 = true;

            //while (eval2)
            //{
            //    eval2 = y.MoveNext();
            //    Console.WriteLine(y.Current);
            //}

            // --------------------------------------------------------

            //Predicate predInt = new Predicate();

            //List<int> myIntList = new List<int>() { 1, 3, 4, 5, 79, 892 };

            //FilterList<int> myFilterList = new FilterList<int>(predInt, myIntList);

            //myFilterList.Print();

            // --------------------------------------------------------

            var harvest = Yielder().Take(3);

            foreach (var x in harvest)
            {
                Console.WriteLine(x);
            }

        }

        public static IEnumerable<int> Yielder()
        {
            int i = 0;
            while (true)
            {
                yield return i;
                i++;
            }
        }

        public interface IPredicate<T>
        {
            bool Evaluate(T t);
        }

        public class Predicate : IPredicate<int>
        {
            public bool Evaluate(int t)
            {
                return t < 3;
            }
        }

        public class FilterList<T> : IList<T>
        {
            private List<T> _list;
            private IPredicate<T> _predicate;
            public FilterList(IPredicate<T> pred, List<T> list)
            {
                this._list = list;
                this._predicate = pred;
            }

            public void Print()
            {
                var aux = _list.GetEnumerator();

                if (this._predicate.Evaluate(aux.Current) && aux.MoveNext())
                {
                    Console.WriteLine(aux.Current);
                }
            }

            public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int Count => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(T item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(T item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                throw new NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

    }
}
