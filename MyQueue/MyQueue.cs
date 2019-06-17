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
            //p_start++;    // 添加队列的时候头指针居然不用自加，WCNMGB哦
            return true;
        }
        // Dequeue 不用移除数据，移除数据时只有头指针会向后移
        public bool Dequeue()
        {
            if (IsEmpty())
                return false;
            //data.Remove(item);
            // 出队列以为只用移除数据就好了，但不是移除数据其头指针还要指向下一个队列头位置
            p_start++;
            return true;
        }

        public T GetFront()
        {
            return data[p_start];
        }

        public int Size()
        {
            return data.Count;
        }

        public bool IsEmpty()
        {
            return p_start >= data.Count;
        }
    }
}
