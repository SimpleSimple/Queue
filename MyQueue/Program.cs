using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new MyQueue<string>();

            Console.WriteLine("队列大小：" + myQueue.Size());

            myQueue.Enqueue("hello");

            Console.WriteLine("队列大小：" + myQueue.Size());

            Console.Read();
        }
    }
}
