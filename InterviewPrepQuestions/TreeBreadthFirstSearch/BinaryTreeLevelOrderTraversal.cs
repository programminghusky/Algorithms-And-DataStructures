/* Given a binary tree, populate an array to represent its level-by-level traversal. 
 * You should populate the values of all nodes of each level from left to right in separate sub-arrays. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;
        public TreeNode(int val)
        {
            this.val = val;
        }
    }
    class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> listOfNodes = new List<IList<int>>();
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            List<int> levelList;

            while (nodes.Count != 0)
            {
                int length = nodes.Count;
                levelList = new List<int>();
                for(int i = 0; i < length; i++)
                {
                    TreeNode node = nodes.Dequeue();
                    levelList.Add(node.val);
                    if(node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
                listOfNodes.Add(levelList);
            }
            return listOfNodes;
        }
    }
}
