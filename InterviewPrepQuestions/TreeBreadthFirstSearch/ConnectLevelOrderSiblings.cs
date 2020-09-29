/* Given a binary tree, connect each node with its level order successor. The last node of each level should point to a null node. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class ConnectLevelOrderSiblings
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return root;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while(queue.Count != 0)
            {
                Node prevNode = null;
                int level = queue.Count;
                for(int i = 0; i< level;i++)
                {
                    Node node = queue.Dequeue();
                    if(prevNode != null)
                    {
                        prevNode.next = node;
                    }
                    prevNode = node;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return root;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }
            public Node(int x)
            {
                val = x;
                left = right = next = null;
            }
        }
    }
}
