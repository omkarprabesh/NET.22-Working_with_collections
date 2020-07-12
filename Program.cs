using System;
using System.Collections;

namespace ClassQueue
{
    public class QCustom<T> : Queue where T : class
    {

        private int _position;

        public void Add(T element)
        {
            if (_position == 10)
            {
                Remove();
            }
            Enqueue(element);
            _position++;

        }

        public void Remove()
        {
            Dequeue();
            _position--;
            Console.WriteLine($"{Dequeue()} has been removed from the queue");
        }
    }

}


