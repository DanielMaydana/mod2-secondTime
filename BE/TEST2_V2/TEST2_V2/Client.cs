using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public class Client
    {
        public string name { get; private set; }
        public int priority { get; private set; }

        public Client(string name, int prio)
        {
            this.name = name;
            this.priority = prio;
        }
    }
}
