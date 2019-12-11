using System;
using Lib1;

namespace ASPDockerTest
{
    public class Album
    {
        public Artist Band { get; protected set; }
        public string Name { get; protected set; }
        public int Year { get; protected set; }

        public Album(Artist band, string name, int year)
        {
            this.Band = band;
            this.Name = name;
            this.Year = year;
        }
    }
}
