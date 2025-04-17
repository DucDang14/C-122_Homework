//Written by Duc Anh Dang
//04/16/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfRecentCalls
{
    
    public class RecentCounter
    {
        private Queue<int> queue;
        public RecentCounter()
        {
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);
            while(t-queue.Peek() > 3000)
            {
                queue.Dequeue();
            }
            return queue.Count;
        }
    }
}
