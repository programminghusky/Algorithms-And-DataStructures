/* Find the largest value on each level of a binary tree. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class LargestValueInEachTreeLevel
    {
        public IList<int> LargestValues(TreeNode root)
        {
            IList<int> listOfNodes = new List<int>();
            if (root == null)
                return listOfNodes;
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            List<int> levelList;

            while (nodes.Count != 0)
            {
                int length = nodes.Count;
                levelList = new List<int>();
                int maxValue = int.MinValue;
                for (int i = 0; i < length; i++)
                {
                    TreeNode node = nodes.Dequeue();
                    maxValue = Math.Max(maxValue, node.val);

                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
                listOfNodes.Add(maxValue);
            }
            return listOfNodes;
        }
    }
}
