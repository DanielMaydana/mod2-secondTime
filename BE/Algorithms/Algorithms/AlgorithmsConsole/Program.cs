using Lists;
using System;

namespace AlgorithmsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList mylist = new LinkedList();
            //mylist.Insert(1, 0);
            //mylist.Insert(2, 1);
            //mylist.Insert(3, 2);
            //mylist.Insert(4, 3);

            //mylist.Show();
            //Console.WriteLine("---------");
            //mylist.ShowReverse();

            //Console.WriteLine("\nNEW CASE\n");

            //mylist.Insert(5, 4);

            //mylist.Show();
            //Console.WriteLine("---------");
            //mylist.ShowReverse();

            //Console.WriteLine("\nNEW CASE\n");

            //mylist.Insert(6, 5);
            //mylist.Insert(7, 6);

            //mylist.Show();
            //Console.WriteLine("---------");
            //mylist.ShowReverse();

            //Console.WriteLine("\nNEW CASE\n");

            //mylist.Insert("INSERT 3", 3);

            //mylist.Show();
            //Console.WriteLine("---------");
            //mylist.ShowReverse();

            //Console.WriteLine("\nNEW CASE\n");

            //mylist.Insert("INSERT 0", 0);

            //mylist.Show();
            //Console.WriteLine("---------");
            //mylist.ShowReverse();

            mylist.Insert(111, 0);
            mylist.Insert(222, 0);
            mylist.Insert(333, 1);

            mylist.Get(1);
            mylist.Get(2);
            mylist.Get(0);
            mylist.Show();
            Console.WriteLine("---------");
            mylist.ShowReverse();
        }
    }


}
