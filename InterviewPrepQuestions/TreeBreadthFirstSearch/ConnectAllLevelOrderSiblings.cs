/* Given a binary tree, connect each node with its level order successor. 
 * The last node of each level should point to the first node of the next level. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class ConnectAllLevelOrderSiblings
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return root;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            Node prevNode = null;
            Node node = null;
            while (queue.Count != 0)
            {
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    node = queue.Dequeue();
                    if (prevNode != null)
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
