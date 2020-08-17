using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class LevelOrderSuccessor
    {
        public TreeNode FindSuccessor(TreeNode root, int key)
        {
            if(root == null)
                return null;
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (nodes.Count != 0)
            {
                TreeNode node = nodes.Dequeue();
                if (node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
                if(node.val == key)
                {
                    break;
                }
            }
            return nodes.Peek();
        }
    }
}
