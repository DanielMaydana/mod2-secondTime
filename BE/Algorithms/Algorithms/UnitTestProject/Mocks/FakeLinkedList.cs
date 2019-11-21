using Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.Mocks
{
    public class FakeLinkedList : LinkedList
    {
        public FakeLinkedList() : base()
        {
            this.Add(111);
            this.Add(222);
            this.Add(333);
            this.Add(444);
            this.Add(555);
        }
    }
}
