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

            Console.WriteLine("Queue size：" + myQueue.Size());

            myQueue.Enqueue("hello");

            Console.WriteLine("Queue size：" + myQueue.Size());
            Console.WriteLine("Front：" + myQueue.GetFront());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("Queue size after dequeue：" + myQueue.Size());
            Console.WriteLine("Get front element after dequeue：" + myQueue.GetFront());
            Console.Read();
        }
    }
}
