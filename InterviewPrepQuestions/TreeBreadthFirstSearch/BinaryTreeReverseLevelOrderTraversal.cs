using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeBreadthFirstSearch
{
    class BinaryTreeReverseLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> listOfNodes = new List<IList<int>>();
            if (root == null)
                return listOfNodes;
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            List<int> levelList;

            while (nodes.Count != 0)
            {
                int length = nodes.Count;
                levelList = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    TreeNode node = nodes.Dequeue();
                    levelList.Add(node.val);
                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
                listOfNodes.Insert(0,levelList);                
            }
            return listOfNodes;
        }
    }
}
