using System;
namespace InterviewStudy
{
    public class LinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int key)
            {
                data = key;
                next = null;
            }
        }

        public void Push(int key)
        {
            Node n = new Node(key);
            n.next = head;
            head = n;
        }
        public void Remove(int key)
        {
            Node n = head;
            Node prev = null;
            if(n != null && n.data == key)
            {
                head = n.next;
                return;
            }
            while(n != null && n.data != key)
            {
                prev = n;
                n = n.next;
            }
            if (n.data == key)
            {
                prev.next = n.next;
            }

        }

        public bool Search(Node head, int key)
        {
            Node n = head;
            while (n != null)
            {
                if (n.data == key)
                    return true;
                n = n.next;
            }
            return false;
        }
    }
}
