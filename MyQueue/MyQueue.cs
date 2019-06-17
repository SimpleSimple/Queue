using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyQueue<T>
    {
        List<T> data;
        int p_start;

        public MyQueue()
        {
            data = new List<T>();
            p_start = 0;
        }

        public bool Enqueue(T item)
        {
            data.Add(item);
            p_start++;
            return true;
        }

        public void Dequeue(T item)
        {
            data.Remove(item);
            // 出队列以为只用移除数据就好了，但不是移除数据其头指针还要指向下一个队列头位置
            p_start++;
        }

        public List<T> GetFront()
        {
            return data.GetRange(p_start, 1);
        }

        public int Size()
        {
            return data.Count;
        }

        public void IsEmpty() { }
    }
}
