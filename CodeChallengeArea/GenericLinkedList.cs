using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeArea
{
    public class GenericLinkedList<T>
    {
        private Node _head = null;
        private List<Node> _nodeList = new();

        private class Node
        {
            public Node Next;
            public T Data;
            public Node Previous;
        }

        public void AddNode(T t)
        {
            var newNode = new Node
            {
                Next = _head,
                Data = t
            };

            _head = newNode;

            //_nodeList.Add(newNode);
        }

        public void InsertAtStart(T t)
        {

        }

        public void InsertInTheMiddle(T t)
        {

        }

        public void InsertAtTheEnd(T t)
        {
            var newNode = new Node
            {
                Next = _head,
                Data = t
            };

            _head = newNode;
        }

        public void RemoveNode(T t)
        {
            var node = _nodeList.Find(x => x.Data.Equals(t));
            var position = _nodeList.FindIndex(0, x => x.Data.Equals(t));
            var previousNode = new Node();

            for (int i = 0; i < _nodeList.Count; i++)
            {
                if (i == position - 1)
                {
                    previousNode = _nodeList.ToArray()[i];
                }
            }

            previousNode.Next = node.Next;
            node.Next = null;
            _head = previousNode;

            _nodeList.Remove(node);
        }

        public void PrintList()
        {
            //foreach (var node in _nodeList)
            //{
            //    Console.WriteLine(node.Data.ToString());
            //}

            Node current = _head;

            while (current != null)
            {
                Console.WriteLine(current.Data.ToString());
                current = current.Next;
            }
        }
    }
}
