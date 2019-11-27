using System;

namespace Lists
{
    public class Element
    {
        public object Value { get; set; }
        public Element NextElem { get; set; }
        public Element PrevElem { get; set; }

        public Element(object value)
        {
            this.Value = value;
        }
    }

    public class RootElement
    {
        public Element First { get; set; }
        public Element Last { get; set; }
    }
}
