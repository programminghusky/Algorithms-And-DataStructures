/* Given a binary tree, find its maximum depth (or height). */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class MaximumDepth
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int maxTreeDepth = 0;
            while(queue.Count != 0)
            {
                maxTreeDepth++;
                int levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    // insert the children of current node in the queue
                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
            }
            return maxTreeDepth;
        }
    }
}
