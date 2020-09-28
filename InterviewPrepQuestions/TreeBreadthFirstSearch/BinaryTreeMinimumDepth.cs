/* Find the minimum depth of a binary tree. The minimum depth is the number of nodes along the shortest path from the root node
 * to the nearest leaf node. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class BinaryTreeMinimumDepth
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int minTreeDepth = 0;
            while (queue.Count != 0)
            {
                minTreeDepth++;
                int levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    if (currentNode.left == null && currentNode.right == null)
                        return minTreeDepth;
                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
            }
            return minTreeDepth;
        }
    }
}
