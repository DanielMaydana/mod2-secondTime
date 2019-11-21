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

            mylist.Insert((object)11, 0);
            mylist.Insert((object)22, 0);
            mylist.Insert((object)33, 1);

            mylist.Show();
            Console.WriteLine("---------");
            mylist.ShowReverse();

            //Console.WriteLine(mylist.Get(0));
            //Console.WriteLine(mylist.Get(1));
            //Console.WriteLine(mylist.Get(2));

            mylist.Contains(11);

            Console.ReadKey();
        }
    }


}
