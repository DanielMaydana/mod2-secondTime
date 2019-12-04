using System;

namespace Lists
{
    public class GenericElement<T>
    {
        public T Value { get; set; }
        public GenericElement<T> NextElem { get; set; }
        public GenericElement<T> PrevElem { get; set; }

        public GenericElement(T value)
        {
            this.Value = value;
        }
    }

    public class GenericRootElement<T>
    {
        public GenericElement<T> First { get; set; }
        public GenericElement<T> Last { get; set; }
    }
}
