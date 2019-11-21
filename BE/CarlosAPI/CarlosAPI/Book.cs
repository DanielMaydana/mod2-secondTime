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
        public Point Point { get; set; }

        public Book()
        {
            this.Point = new Point();
        }
    }

    public class Point
    {
        public const uint X = 10;
        public const uint y = 88;
    }
}
