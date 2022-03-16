using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeArea
{
    public class GenericLinkedList<T>
    {
        public Node Head { get; private set; } = null;
        public int Length { get; private set; } = 0;

        public class Node
        {
            public Node Next;
            public T Data;
        }

        public void InsertAtStart(T t)
        {
            var newNode = new Node
            {
                Next = Head,
                Data = t
            };

            Head = newNode;
            Length++;
        }

        public void InsertInTheMiddle(T t)
        {
            var newNode = new Node()
            {
                Next = Head.Next,
                Data = t
            };

            Head.Next = newNode;
            Length++;
        }

        public void InsertAtTheEnd(T t)
        {
            var newNode = new Node()
            {
                Next = null,
                Data = t
            };

            Head.Next = newNode;
            Length++;
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);

            if (index == 0)
            {
                Head = Head.Next;
            }
            else
            {
                Node current = Head;
                for (int i = 0; i < index-1; i++)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;
            }

            Length--;
        }

        public void PrintList()
        {
            Node current = Head;
            var stringList = new StringBuilder();

            while (current != null)
            {
                stringList.Append(current.Data.ToString() + " ");
                current = current.Next;
            }

            Console.WriteLine($"Result: {stringList}");
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException($"Index {index} out of bounds");
            }
        }

        public T GetElement(int index)
        {
            CheckIndex(index);

            Node current = Head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        public int IndexOf(T t)
        {
            Node current = Head;
            int index = 0;

            while (current != null && !current.Data.Equals(t))
            {
                current = current.Next;
                index++;
            }

            if (current == null)
            {
                return -1;
            }

            return index;
        }
    }
}
