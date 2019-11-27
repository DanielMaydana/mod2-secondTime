using System;
using System.Threading;

namespace TEST2_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue myQueue = new PriorityQueue(3);

            //myQueue.Enqueue(new Client("Dan", 1));
            //myQueue.Enqueue(new Client("Cleo", 3));
            //myQueue.Enqueue(new Client("Angela", 1));
            //myQueue.Enqueue(new Client("Jon", 2));

            //Console.WriteLine(((Client)myQueue.Dequeue()).name);
            //Console.WriteLine(((Client)myQueue.Dequeue()).name);
            //Console.WriteLine(((Client)myQueue.Dequeue()).name);
            //Console.WriteLine(((Client)myQueue.Dequeue()).name);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("[1] Queue");
                Console.WriteLine("[2] Dequeue");
                Console.WriteLine("[X] Exit");

                string pressedKey = Console.ReadKey().Key.ToString();

                switch (pressedKey)
                {
                    case "D1":
                        Console.Clear();
                        Console.WriteLine("Client's name");
                        string name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Client's priority");
                        int priority;
                        int.TryParse(Console.ReadLine(), out priority);

                        if(priority > 3)
                        {
                            Console.WriteLine("** Priority can't be greater than 3. **");
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Queued: [{0}, {1}]", name, priority);
                            myQueue.Enqueue(new Client(name, priority));
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }


                    case "D2":
                        Console.Clear();

                        var dequeued = ((Client)myQueue.Dequeue());

                        if (dequeued == null)
                        {
                            Console.WriteLine("** There are no clients in the queue. **");
                        }
                        else
                        {
                            Console.WriteLine("Dequeued: [{0}, {1}]", dequeued.name, dequeued.priority);
                        }

                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    case "X":
                        exit = true;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
        }


    }
}
