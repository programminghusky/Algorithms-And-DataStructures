/* Given a binary tree, populate an array to represent the averages of all of its levels. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class BinaryTreeLevelAverages
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> avgs = new List<double>();
            if (root == null)
                return avgs;
            Queue<TreeNode> qNodes = new Queue<TreeNode>();
            qNodes.Enqueue(root);
            while (qNodes.Count != 0)
            {
                List<int> intList = new List<int>();
                int length = qNodes.Count;
                for (int i = 0; i < length; i++)
                {
                    TreeNode node = qNodes.Dequeue();
                    intList.Add(node.val);
                    if (node.left != null)
                        qNodes.Enqueue(node.left);
                    if (node.right != null)
                        qNodes.Enqueue(node.right);
                }
                double sum = 0;
                foreach (int val in intList)
                    sum += val;

                avgs.Add(sum / intList.Count);
            }
            return avgs;
        }
    }
}
