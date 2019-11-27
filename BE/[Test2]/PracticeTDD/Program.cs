using Implementations;
using Interfaces;
using System;
using System.Threading;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue myQueue = new PriorityQueue(new LinkedList(), new LinkedList(), new LinkedList(), new IsPriority());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Exit");

                string stringedKey = Console.ReadKey().Key.ToString();

                switch (stringedKey)
                {
                    case "D1":
                            int priority = 0;
                            string user = "";

                            Console.Clear();
                            Console.WriteLine("1. Register Priority");

                            int.TryParse((Console.ReadLine()), out priority);

                            Console.Clear();

                            Console.WriteLine("2. Register User");

                            user = Console.ReadLine();
                            myQueue.Enqueue(priority, user);
                            Console.Clear();


                        break;

                    case "D2":
                        Console.Clear();
                        Console.WriteLine(myQueue.Dequeue());
                        Thread.Sleep(1500);
                        Console.Clear();

                        break;

                    case "D3":
                        Console.Clear();
                        Console.WriteLine("BYE");
                        Thread.Sleep(1500);
                        Console.Clear();

                        break;
                }
            }

        }
    }
}
