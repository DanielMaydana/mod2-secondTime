using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public class PriorityQueue : IQueue
    {
        BasicQueue[] allQueues;

        public PriorityQueue(int n)
        {
            allQueues = new BasicQueue[n];

            for(int i = 0; i < n; i++)
            {
                allQueues[i] = new BasicQueue();
            }
        }

        public object Dequeue()
        {
            var endPosition = allQueues.Length - 1;

            for (int i = endPosition; i > (-1); i--)
            {
                if(!allQueues[i].isEmpty())
                {
                    return allQueues[i].Dequeue();
                }
            }
            return null;
        }

        public void Enqueue(object cli)
        {
            int prioritySelection = ((Client)cli).priority - 1;
            allQueues[prioritySelection].Enqueue(cli);
        }

        public bool isEmpty()
        {
            var endPosition = allQueues.Length - 1;
            var isEmpty = true;

            for (int i = endPosition; i > (-1); i--)
            {
                if (allQueues[i].isEmpty())
                {
                    isEmpty = false;
                    break;
                }
            }
            
            return isEmpty;
        }
    }
}
