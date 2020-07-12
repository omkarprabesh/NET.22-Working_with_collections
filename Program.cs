using System;
using System.Collections;

namespace ClassQueue
{
    public class QCustom<T> : Queue
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
        public class Execute
        {
            static void Main()
            {
                QCustom<string> CheckList = new QCustom<string>();
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("One");
                CheckList.Add("Two");
                CheckList.Remove();
            foreach (var x in CheckList)
                    Console.WriteLine(x);
            }
        }
    }


