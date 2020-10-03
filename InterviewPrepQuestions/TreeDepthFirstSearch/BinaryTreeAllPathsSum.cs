/* Given a binary tree and a number ‘S’, find all paths from root-to-leaf 
 * such that the sum of all the node values of each path equals ‘S’. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeDepthFirstSearch
{
    class BinaryTreeAllPathsSum
    {
        public static TreeNode Root;
        public void InsertRecursive(int num)
        {
            if (Root == null)
            {
                TreeNode node = new TreeNode(num);
                Root = node;
            }
            else
            {
                InsRecursive(Root, num);
            }
        }

        private TreeNode InsRecursive(TreeNode root, int num)
        {

            if (root == null)
            {
                root = new TreeNode(num);
                root.left = null;
                root.right = null;
                return root;
            }
            if (num < Root.val)
            {
                root.left = InsRecursive(root.left, num);
            }
            else
            {
                root.right = InsRecursive(root.right, num);
            }
            return root;
        }

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> allPaths = new List<IList<int>>();
            List<int> pathNodes = new List<int>();
            RecurseTree(root, sum, pathNodes, allPaths);
            return allPaths;
        }

        private void RecurseTree(TreeNode node, int remainingSum, List<int> pathNodes, IList<IList<int>> allPaths)
        {
            if (node == null)
                return;

            pathNodes.Add(node.val);

            if (remainingSum == node.val && node.left == null && node.right == null)
            {
                allPaths.Add(new List<int>(pathNodes));
            }
            else
            {
                RecurseTree(node.left, remainingSum - node.val, pathNodes, allPaths);
                RecurseTree(node.right, remainingSum - node.val, pathNodes, allPaths);
            }

            pathNodes.RemoveAt(pathNodes.Count - 1);
        }
    }
}
