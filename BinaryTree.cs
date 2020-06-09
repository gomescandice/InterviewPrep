using System;
using System.Collections.Generic;
namespace InterviewStudy
{
    public class BinaryTree
    {
        public Node root;
        public class Node
        {
            public int key;
            public Node left, right;
            public Node(int data)
            {
                key = data;
                left = right = null;
            }
        }

        public void Insert(int key)
        {
            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);
            
            while (Q.Count != 0)
            {
                Node n = Q.Peek();
                if (n.left == null)
                {
                    n.left = new Node(key);
                    break;
                }
                else
                    Q.Enqueue(n.left);
                if (n.right == null)
                {
                    n.right = new Node(key);
                    break;
                }
                else
                    Q.Enqueue(n.right);
            }

        }

        public void Delete(int k)
        {

        }

        public bool Search (Node next, int k)
        {
      
            if (root == null)
                return false;
            else
            {
                if (root.key == k)
                    return true;
                else if (root.left != null)
                {
                    next = next.left;
                    return Search(next,k);
                }
                else if (root.right != null)
                {
                    next = next.right;
                    return Search(next,k);
                }
            }
            return false;
        }
    }
}
