/* Given a binary tree, return an array containing nodes in its right view. The right view of a binary tree is the
 * set of nodes visible when the tree is seen from the right side.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class RightVewOfBinaryTree
    {
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
                return result;
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (nodes.Count != 0)
            {
                int length = nodes.Count;
                for (int i = 0; i < length; i++)
                {
                    TreeNode node = nodes.Dequeue();
                    if (i == length - 1)
                        result.Add(node.val);
                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
            }


            return result;
        }
    }
}
