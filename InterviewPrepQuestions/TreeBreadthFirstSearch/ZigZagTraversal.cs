/*Given a binary tree, populate an array to represent its zigzag level order traversal. 
 * You should populate the values of all nodes of the first level from left to right,
 * then right to left for the next level and keep alternating in the same manner for the following levels. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class ZigZagTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> listOfNodes = new List<IList<int>>();
            if (root == null)
                return listOfNodes;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            List<int> levelList;
            bool leftToRigth = true;
            while(queue.Count != 0)
            {
                int length = queue.Count;
                levelList = new List<int>();
                for(int i = 0; i< length;i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (leftToRigth)
                        levelList.Add(node.val);
                    else
                        levelList.Insert(0, node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                listOfNodes.Add(levelList);
                leftToRigth = !leftToRigth;
            }
            return listOfNodes;
        }
    }
}
