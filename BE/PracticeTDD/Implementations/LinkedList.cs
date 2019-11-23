using Interfaces;
using System;

namespace Implementations
{
    public class LinkedList : IList
    {
        private RootNode root;
        private int size;

        public LinkedList()
        {
            this.size = 0;
            this.root = new RootNode();
        }

        public void Add(object toAdd)
        {
            this.Insert(toAdd, this.size);
        }

        public void Delete(object toDelete)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object toFind)
        {
            throw new NotImplementedException();
        }

        public void Insert(object toInsert, int position)
        {
            this.ValidatePosition(position);

            Node nodeToInsert = new Node(toInsert);

            if (this.size == 0 && position == 0)
            {
                InsertFirstNode(nodeToInsert);
            }
            else if (this.size == position && this.size > 0)
            {
                InsertNodeAtTheEnd(nodeToInsert);
            }
            else if (this.size > 0 && position == 0)
            {
                InsertNodeAtTheBeginning(nodeToInsert);
            }
            else if (this.size > position && position > 0)
            {
                InsertNodeAtTheMiddle(nodeToInsert, position);
            }

            this.size++;
        }

        public object Get(int position)
        {
            return null;
        }

        public int Size()
        {
            return this.size;
        }

        private void ValidatePosition(int position)
        {
            if (position < 0 || position > this.size)
            {
                throw new ArgumentException("Position is out of range.");
            }
        }


        public void Show()
        {
            Node current = this.root.First;

            Console.WriteLine("----------------");

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine("----------------");
        }

        public void ShowReverse()
        {
            Node current = this.root.Last;

            Console.WriteLine("----------------");

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }

            Console.WriteLine("----------------");
        }


        private void InsertFirstNode(Node nodeToInsert)
        {
            this.root.First = this.root.Last = nodeToInsert;
        }

        private void InsertNodeAtTheEnd(Node nodeToInsert)
        {
            nodeToInsert.Previous = this.root.Last;
            this.root.Last.Next = nodeToInsert;
            this.root.Last = nodeToInsert;
        }

        private void InsertNodeAtTheBeginning(Node nodeToInsert)
        {
            nodeToInsert.Next = this.root.First;
            this.root.First.Previous = nodeToInsert;
            this.root.First = nodeToInsert;
        }

        private void InsertNodeAtTheMiddle(Node nodeToInsert, int position)
        {
            Node later = this.root.First;
            uint index = 0;

            while (index < position)
            {
                later = later.Next;
                index++;
            }

            Node prior = later.Previous;

            prior.Next = nodeToInsert;
            later.Previous = nodeToInsert;
            nodeToInsert.Previous = prior;
            nodeToInsert.Next = later;
        }
    }

    public class RootNode
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public RootNode()
        {
            this.First = this.Last = null;
        }
    }

    public class Node
    {
        public Node Previous { get; set; }
        public Node Next { get; set; }
        public object Value { get; set; }

        public Node(object value)
        {
            this.Previous = this.Next = null;
            this.Value = value;
        }
    }
}