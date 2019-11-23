using Implementations;
using Interfaces;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();

            myList.Add(111);
            myList.Add(222);
            myList.Add(333);

            myList.Show();
            myList.ShowReverse();
        }
    }
}
