using System;

namespace AlgorithmsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();

            int number = 10;

            MyMethod(myclass, ref number);

            Console.WriteLine("f1: {0} f2:{1}", myclass.value, number);

            Rectangle rect = new Rectangle(8, 3);

            rect.GetArea(h: 2, b: 1);
        }

        static void MyMethod(MyClass myclass, ref int number)
        {
            myclass.value += 5;
            number += 5;

            Console.WriteLine("f1: {0} f2:{1}", myclass.value, number);
        }

        static void MyMethod2(params int[] args)
        {
            foreach (var elem in args)
            {
                Console.WriteLine(elem);
            }
        }
    }

    public class Rectangle
    {
        public uint b { get; set; }
        public uint h { get; set; }

        public Rectangle(uint b, uint h)
        {
            this.b = b;
            this.h = h;
        }

        public uint GetArea(uint b, uint h)
        {
            return b * h;
        }
    }

    public class MyClass
    {
        public int value = 20;
    }
}
