using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public class Element
    {
        public Element Next { get; set; }
        public object Value { get; private set; }

        public Element(object value)
        {
            Value = value;

        }
    }
}
