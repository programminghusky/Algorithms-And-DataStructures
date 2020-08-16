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
            if (root.left == null)
                return MinDepth(root.right) + 1;
            if (root.right == null)
                return MinDepth(root.left) + 1;

            return Math.Min((1 + MinDepth(root.left)), (1 + MinDepth(root.right)));
        }
    }
}
