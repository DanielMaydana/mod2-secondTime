using System;

namespace Lib1
{
    public class Artist
    {
        public string Name { get; protected set; }
        public int Members { get; protected set; }

        public Artist(string name, int members)
        {
            this.Name = name;
            this.Members = members;
        }
    }
}
