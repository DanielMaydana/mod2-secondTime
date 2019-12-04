using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarlosAPI
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public uint Isbn { get; set; }
        public Point myPoint { get; set; }

        public Book()
        {
        }
    }

    public class Point
    {
        public uint x;
        public uint y;

        public Point(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
